using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Sockets;
using Renci.SshNet;
using Renci.SshNet.Common;
using NetworkFriendFinder.Data.Models;

namespace NetworkFriendFinder.Data.Services
{
	public class SshService
	{
		private CurrentUser _currentUser;

		public SshService(CurrentUser currentUser)
		{
			_currentUser = currentUser;
		}

		public static bool TestCredentials(PasswordConnectionInfo connectionInfo)
		{
			bool connected = false;
			using (SshClient ssh = new SshClient(connectionInfo))
			{
				try
				{
					ssh.Connect();
					connected = ssh.IsConnected;
				}
				catch (SshAuthenticationException) { connected = false; }
			}
			return connected;
		}

		public void GetUsers(object sender, BackgroundWorker worker, Delegate sendUsers)
		{
			foreach (string host in SshSettings.Hosts())
			{
				if (worker.CancellationPending)
					break;

				List<SshUser> users = new List<SshUser>();
				using (SshClient ssh = new SshClient(_currentUser.GetPasswordConenctionInfo(String.Concat(host, SshSettings.Domain))))
				{
					try
					{
						ssh.Connect();
						string response = ssh.RunCommand("who -u").Execute();
						// TODO: Parse response.
						ParseWhoResponse(response, host, ref users);
						if (users.Count > 0)
							((System.Windows.Forms.Form) sender).Invoke(sendUsers, users);
					}
					catch (Exception ex)
					{
						if (ex is SshException || ex is SocketException)
						{
							if (ssh.IsConnected)
								ssh.Disconnect();
							ssh.Dispose();
						}
						else
						{
							throw;
						}
					}
				}
			}
		}

		private void ParseWhoResponse(string response, string host, ref List<SshUser> users)
		{
			MatchCollection matchs = Regex.Matches(response, @"^(\S*\b)\s*(\S*\b)", RegexOptions.Multiline);
			foreach (Match match in matchs)
			{
				users.Add(new SshUser(match.Groups[1].ToString(), host, match.Groups[2].ToString()));
			}
		}
	}
}

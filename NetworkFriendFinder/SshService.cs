using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Common;

namespace NetworkFriendFinder
{
	public class SshService
	{
		private PasswordConnectionInfo _connectionInfo;

		public SshService(PasswordConnectionInfo connectionInfo)
		{
			_connectionInfo = connectionInfo;
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
	}
}

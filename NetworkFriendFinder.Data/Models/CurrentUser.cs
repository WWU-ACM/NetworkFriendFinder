using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Common;

namespace NetworkFriendFinder.Data.Models
{
	public class CurrentUser
	{
		private string _user;
		public string User
		{
			get { return _user; }
		}

		private string _password;

		public CurrentUser(string userName, string password)
		{
			_user = userName;
			_password = password;
		}

		public PasswordConnectionInfo GetPasswordConenctionInfo(string host)
		{
			return new PasswordConnectionInfo(host, _user, _password);
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkFriendFinder.Data.Models
{
	public class SshUser
	{
		private string _user;
		public string User
		{
			get { return _user; }
		}

		private string _host;
		public string Host
		{
			get { return _host; }
		}

		public SshUser(string user, string host)
		{
			_user = user;
			_host = host;
		}
		
	}
}

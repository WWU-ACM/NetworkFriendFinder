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
			set { _host = value; }
		}

		private string _term;
		public string Term
		{
			get { return _term; }
			set { _term = value; }
		}

		public SshUser(string user, string host, string term)
		{
			_user = user;
			_host = host;
			_term = term;
		}

		public override string ToString()
		{
			return _user;
		}
		
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkFriendFinder
{
	public static class Settings
	{
		public const string Host = "cf416.cs.wwu.edu";
		public const string Domain = ".cs.wwu.edu";

		public static List<string> Hosts()
		{
			List<string> nodes = new List<string>();
			for (int i = 1; i <= 20; i++)
				nodes.Add(String.Format("cf416-{0,2:D2}", i));
			for (int i = 1; i <= 20; i++)
				nodes.Add(String.Format("cf162-{0,2:D2}", i));
			for (int i = 1; i <= 20; i++)
				nodes.Add(String.Format("cf164-{0,2:D2}", i));
			for (int i = 1; i <= 20; i++)
				nodes.Add(String.Format("cf405-{0,2:D2}", i));
			for (int i = 1; i <= 20; i++)
				nodes.Add(String.Format("cf414-{0,2:D2}", i));
			
			return nodes;
		}
	}
}

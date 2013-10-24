using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Common;
using NetworkFriendFinder.Data;
using NetworkFriendFinder.Data.Models;

namespace NetworkFriendFinder
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			CurrentUser _currentUser = null;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			LoginForm loginForm = new LoginForm();
			DialogResult result = loginForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				_currentUser = loginForm.CurrentUser;
				loginForm.Dispose();

				Application.Run(new FriendFinder(_currentUser));
			}
		}
	}
}

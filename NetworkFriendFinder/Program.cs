using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Common;

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
			PasswordConnectionInfo _connectionInfo = null;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			LoginForm loginForm = new LoginForm();
			DialogResult result = loginForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				_connectionInfo = loginForm.ConnectionInfo;
				loginForm.Dispose();

				Application.Run(new FriendFinder(_connectionInfo));
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;

namespace NetworkFriendFinder
{
	public partial class Form1 : Form
	{
		private SshClient _ssh;

		public Form1()
		{
			InitializeComponent();
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(userEdit.Text))
			{
				MessageBox.Show("Please enter a username.");
			}
			else if (String.IsNullOrEmpty(passwordEdit.Text))
			{
				MessageBox.Show("Please enter a password");
			}
			else
			{
				_ssh = new SshClient(Settings.Host, userEdit.Text, passwordEdit.Text);
				_ssh.Connect();
				MessageBox.Show(_ssh.ConnectionInfo.IsAuthenticated ? "Logged in" : "Connection Failed");
			}
			
		}
	}
}

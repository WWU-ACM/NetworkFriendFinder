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
using Renci.SshNet.Common;
using NetworkFriendFinder.Data.Models;
using NetworkFriendFinder.Data.Services;

namespace NetworkFriendFinder
{
	public partial class LoginForm : Form
	{
		private SshClient _ssh;
		private CurrentUser _currentUser;
		public CurrentUser CurrentUser
		{
			get { return _currentUser; }
		}

		public LoginForm()
		{
			InitializeComponent();
			statusLabel.Text = String.Empty;
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(userLabel.Text))
			{
				statusLabel.Text = "Please enter a username.";
			}
			else if (String.IsNullOrEmpty(passwordLabel.Text))
			{
				statusLabel.Text = "Please enter a password";
			}
			else
			{
				_currentUser = new CurrentUser(userEdit.Text, passwordEdit.Text);
				if (SshService.TestCredentials(_currentUser.GetPasswordConenctionInfo(SshSettings.Host)))
				{
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
					this.Close();
				}
				else
				{
					statusLabel.Text = "Incorrect username or password.";
				}
			}	
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}
	}
}

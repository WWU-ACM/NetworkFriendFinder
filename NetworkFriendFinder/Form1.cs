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
			_ssh = new SshClient(Settings.Host, Settings.User, Settings.Password);
		}

		private void execBtn_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(execBtn.Text))
			{
				_ssh.Connect();
				SshCommand cmd = _ssh.CreateCommand(execBtn.Text);
				string response = cmd.Execute();
			}
		}
	}
}

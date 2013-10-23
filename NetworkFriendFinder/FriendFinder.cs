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

namespace NetworkFriendFinder
{
	public partial class FriendFinder : Form
	{
		private PasswordConnectionInfo _connectionInfo;

		public FriendFinder(PasswordConnectionInfo connectionInfo)
		{
			InitializeComponent();
			_connectionInfo = connectionInfo;
		}
	}
}

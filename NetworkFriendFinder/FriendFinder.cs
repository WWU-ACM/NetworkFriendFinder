using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Common;
using NetworkFriendFinder.Data.Models;
using NetworkFriendFinder.Data.Services;

namespace NetworkFriendFinder
{
	public partial class FriendFinder : Form
	{
		private CurrentUser _currentUser;
		private SshService _sshService;
		private BindingList<SshUser> _otherUsers;

		private BackgroundWorker _friendFinder;
		private delegate void updateFriendListDelagate(List<SshUser> users);
		updateFriendListDelagate _updateFriendsList;

		public FriendFinder(CurrentUser currentUser)
		{
			InitializeComponent();

			// Init members
			_currentUser = currentUser;
			_sshService = new SshService(_currentUser);
			_otherUsers = new BindingList<SshUser>();
			otherUsersGrid.DataSource = _otherUsers;

			// Init background worker
			_friendFinder = new BackgroundWorker();
			_friendFinder.WorkerSupportsCancellation = true;
			_friendFinder.DoWork += _friendFinder_DoWork;

			// Init delegates.
			_updateFriendsList = new updateFriendListDelagate(updateFriendsList);

			// Start'er Up
			tryGetUsers();
		}

		#region Private methods

		private void _friendFinder_DoWork(object sender, DoWorkEventArgs e)
		{
			//Running on background thread:
			BackgroundWorker worker = (BackgroundWorker) sender;
			_sshService.GetUsers((object) this, worker, (Delegate) e.Argument);
		}

		private void updateFriendsList(List<SshUser> users)
		{
			foreach (SshUser user in users)
				_otherUsers.Add(user);
		}

		private void tryGetUsers()
		{
			if (!_friendFinder.IsBusy)
				_friendFinder.RunWorkerAsync(_updateFriendsList);
		}

		#endregion
	}
}

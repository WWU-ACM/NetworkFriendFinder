namespace NetworkFriendFinder
{
	partial class FriendFinder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.otherUsersGrid = new System.Windows.Forms.DataGridView();
			this.searchEdit = new System.Windows.Forms.TextBox();
			this.searchLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.otherUsersGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// otherUsersGrid
			// 
			this.otherUsersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.otherUsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.otherUsersGrid.Location = new System.Drawing.Point(12, 51);
			this.otherUsersGrid.Name = "otherUsersGrid";
			this.otherUsersGrid.Size = new System.Drawing.Size(150, 248);
			this.otherUsersGrid.TabIndex = 0;
			// 
			// searchEdit
			// 
			this.searchEdit.Location = new System.Drawing.Point(12, 25);
			this.searchEdit.Name = "searchEdit";
			this.searchEdit.Size = new System.Drawing.Size(150, 20);
			this.searchEdit.TabIndex = 1;
			// 
			// searchLabel
			// 
			this.searchLabel.AutoSize = true;
			this.searchLabel.Location = new System.Drawing.Point(12, 9);
			this.searchLabel.Name = "searchLabel";
			this.searchLabel.Size = new System.Drawing.Size(41, 13);
			this.searchLabel.TabIndex = 2;
			this.searchLabel.Text = "Search";
			// 
			// FriendFinder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 311);
			this.Controls.Add(this.searchLabel);
			this.Controls.Add(this.searchEdit);
			this.Controls.Add(this.otherUsersGrid);
			this.Name = "FriendFinder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Friend Finder";
			((System.ComponentModel.ISupportInitialize)(this.otherUsersGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView otherUsersGrid;
		private System.Windows.Forms.TextBox searchEdit;
		private System.Windows.Forms.Label searchLabel;
	}
}
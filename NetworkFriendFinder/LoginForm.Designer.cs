namespace NetworkFriendFinder
{
	partial class LoginForm
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
			this.userEdit = new System.Windows.Forms.TextBox();
			this.loginBtn = new System.Windows.Forms.Button();
			this.userLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordEdit = new System.Windows.Forms.TextBox();
			this.statusLabel = new System.Windows.Forms.Label();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// userEdit
			// 
			this.userEdit.Location = new System.Drawing.Point(12, 25);
			this.userEdit.Name = "userEdit";
			this.userEdit.Size = new System.Drawing.Size(260, 20);
			this.userEdit.TabIndex = 0;
			// 
			// loginBtn
			// 
			this.loginBtn.Location = new System.Drawing.Point(172, 124);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(100, 25);
			this.loginBtn.TabIndex = 2;
			this.loginBtn.Text = "Login";
			this.loginBtn.UseVisualStyleBackColor = true;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.BackColor = System.Drawing.Color.Transparent;
			this.userLabel.Location = new System.Drawing.Point(10, 7);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(29, 13);
			this.userLabel.TabIndex = 2;
			this.userLabel.Text = "User";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
			this.passwordLabel.Location = new System.Drawing.Point(10, 48);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(53, 13);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "Password";
			// 
			// passwordEdit
			// 
			this.passwordEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordEdit.Location = new System.Drawing.Point(12, 64);
			this.passwordEdit.Name = "passwordEdit";
			this.passwordEdit.PasswordChar = '*';
			this.passwordEdit.Size = new System.Drawing.Size(260, 20);
			this.passwordEdit.TabIndex = 1;
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Location = new System.Drawing.Point(12, 87);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(37, 13);
			this.statusLabel.TabIndex = 4;
			this.statusLabel.Text = "Status";
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(12, 124);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(100, 25);
			this.cancelBtn.TabIndex = 5;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 161);
			this.ControlBox = false;
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.passwordEdit);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.userEdit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox userEdit;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordEdit;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Button cancelBtn;
	}
}


namespace NetworkFriendFinder
{
	partial class Form1
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.loginBtn = new System.Windows.Forms.Button();
			this.userEdit = new System.Windows.Forms.Label();
			this.passwordEdit = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 20);
			this.textBox1.TabIndex = 0;
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
			// userEdit
			// 
			this.userEdit.AutoSize = true;
			this.userEdit.Location = new System.Drawing.Point(12, 9);
			this.userEdit.Name = "userEdit";
			this.userEdit.Size = new System.Drawing.Size(32, 13);
			this.userEdit.TabIndex = 2;
			this.userEdit.Text = "User:";
			// 
			// passwordEdit
			// 
			this.passwordEdit.AutoSize = true;
			this.passwordEdit.Location = new System.Drawing.Point(9, 48);
			this.passwordEdit.Name = "passwordEdit";
			this.passwordEdit.Size = new System.Drawing.Size(56, 13);
			this.passwordEdit.TabIndex = 3;
			this.passwordEdit.Text = "Password:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(260, 20);
			this.textBox2.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 161);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.passwordEdit);
			this.Controls.Add(this.userEdit);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Friend Finder";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.Label userEdit;
		private System.Windows.Forms.Label passwordEdit;
		private System.Windows.Forms.TextBox textBox2;
	}
}


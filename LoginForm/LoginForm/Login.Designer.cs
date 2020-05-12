﻿namespace LoginForm
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.emailLogin = new System.Windows.Forms.TextBox();
			this.mailBarLogin = new System.Windows.Forms.FlowLayoutPanel();
			this.emailImg = new System.Windows.Forms.PictureBox();
			this.passBarLogin = new System.Windows.Forms.FlowLayoutPanel();
			this.passwordLogin = new System.Windows.Forms.TextBox();
			this.passImg = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.MainMenuButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.emailImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.passImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// emailLogin
			// 
			this.emailLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.emailLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.emailLogin.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLogin.ForeColor = System.Drawing.Color.LightGray;
			this.emailLogin.Location = new System.Drawing.Point(68, 160);
			this.emailLogin.Margin = new System.Windows.Forms.Padding(2);
			this.emailLogin.Name = "emailLogin";
			this.emailLogin.Size = new System.Drawing.Size(156, 17);
			this.emailLogin.TabIndex = 24;
			this.emailLogin.Click += new System.EventHandler(this.emailLogin_TextChanged);
			// 
			// mailBarLogin
			// 
			this.mailBarLogin.BackColor = System.Drawing.Color.White;
			this.mailBarLogin.Location = new System.Drawing.Point(37, 185);
			this.mailBarLogin.Margin = new System.Windows.Forms.Padding(2);
			this.mailBarLogin.Name = "mailBarLogin";
			this.mailBarLogin.Size = new System.Drawing.Size(188, 1);
			this.mailBarLogin.TabIndex = 23;
			// 
			// emailImg
			// 
			this.emailImg.Image = ((System.Drawing.Image)(resources.GetObject("emailImg.Image")));
			this.emailImg.Location = new System.Drawing.Point(37, 155);
			this.emailImg.Margin = new System.Windows.Forms.Padding(2);
			this.emailImg.Name = "emailImg";
			this.emailImg.Size = new System.Drawing.Size(23, 25);
			this.emailImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.emailImg.TabIndex = 22;
			this.emailImg.TabStop = false;
			// 
			// passBarLogin
			// 
			this.passBarLogin.BackColor = System.Drawing.Color.White;
			this.passBarLogin.Location = new System.Drawing.Point(37, 223);
			this.passBarLogin.Margin = new System.Windows.Forms.Padding(2);
			this.passBarLogin.Name = "passBarLogin";
			this.passBarLogin.Size = new System.Drawing.Size(188, 1);
			this.passBarLogin.TabIndex = 21;
			// 
			// passwordLogin
			// 
			this.passwordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.passwordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordLogin.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLogin.ForeColor = System.Drawing.Color.LightGray;
			this.passwordLogin.Location = new System.Drawing.Point(65, 199);
			this.passwordLogin.Margin = new System.Windows.Forms.Padding(2);
			this.passwordLogin.Name = "passwordLogin";
			this.passwordLogin.Size = new System.Drawing.Size(156, 17);
			this.passwordLogin.TabIndex = 20;
			this.passwordLogin.UseSystemPasswordChar = true;
			this.passwordLogin.Click += new System.EventHandler(this.passwordLogin_TextChanged);
			// 
			// passImg
			// 
			this.passImg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.passImg.Image = ((System.Drawing.Image)(resources.GetObject("passImg.Image")));
			this.passImg.Location = new System.Drawing.Point(37, 193);
			this.passImg.Margin = new System.Windows.Forms.Padding(2);
			this.passImg.Name = "passImg";
			this.passImg.Size = new System.Drawing.Size(23, 25);
			this.passImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.passImg.TabIndex = 19;
			this.passImg.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(96, 44);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(72, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 25;
			this.pictureBox1.TabStop = false;
			// 
			// MainMenuButton
			// 
			this.MainMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MainMenuButton.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuButton.ForeColor = System.Drawing.Color.LightGray;
			this.MainMenuButton.Location = new System.Drawing.Point(37, 310);
			this.MainMenuButton.Margin = new System.Windows.Forms.Padding(2);
			this.MainMenuButton.Name = "MainMenuButton";
			this.MainMenuButton.Size = new System.Drawing.Size(188, 32);
			this.MainMenuButton.TabIndex = 27;
			this.MainMenuButton.Text = "Main Menu";
			this.MainMenuButton.UseVisualStyleBackColor = false;
			this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.loginButton.Location = new System.Drawing.Point(37, 261);
			this.loginButton.Margin = new System.Windows.Forms.Padding(2);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(188, 32);
			this.loginButton.TabIndex = 26;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.ClientSize = new System.Drawing.Size(275, 422);
			this.Controls.Add(this.MainMenuButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.emailLogin);
			this.Controls.Add(this.mailBarLogin);
			this.Controls.Add(this.emailImg);
			this.Controls.Add(this.passBarLogin);
			this.Controls.Add(this.passwordLogin);
			this.Controls.Add(this.passImg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.emailImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.passImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox emailLogin;
		private System.Windows.Forms.FlowLayoutPanel mailBarLogin;
		private System.Windows.Forms.PictureBox emailImg;
		private System.Windows.Forms.FlowLayoutPanel passBarLogin;
		private System.Windows.Forms.TextBox passwordLogin;
		private System.Windows.Forms.PictureBox passImg;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button MainMenuButton;
		private System.Windows.Forms.Button loginButton;
	}
}
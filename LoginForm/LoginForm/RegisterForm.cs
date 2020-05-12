﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LoginForm
{
	public partial class RegisterForm : Form
	{

		public RegisterForm()
		{
			InitializeComponent();
		}

		/// <summary>
		///  Register method - Determins if a user has been inserted or not.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void  register_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(usernameRegister.Text))
			{
				MessageBox.Show("Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
			if(passwordRegister.Text != confirmPasswordRegister.Text)
			{
				MessageBox.Show("Password don't match! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			IUserRepository repository = new UserRepository();
			bool result = await repository.Insert(new User() { UserName = usernameRegister.Text, Password = passwordRegister.Text, Email = emailRegister.Text });

			if (result)
			{
				MessageBox.Show("You have successfully signed in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		/// <summary>
		///  Changes the color of both, the username textBox and the text.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void username_Click(object sender, EventArgs e)
		{
			usernameRegister.Clear();

			userBarRegister.BackColor = Color.FromArgb(3, 174, 218);
			usernameRegister.ForeColor = Color.FromArgb(3, 174, 218);

			passBarRegister.BackColor = Color.WhiteSmoke;
			passwordRegister.ForeColor = Color.WhiteSmoke;

			confirmPasswordRegister.ForeColor = Color.WhiteSmoke;
			confirmPassBar.BackColor = Color.WhiteSmoke;

			mailBarRegister.BackColor = Color.WhiteSmoke;
			emailRegister.ForeColor = Color.WhiteSmoke;
		}


		/// <summary>
		/// Changes the color of both, the password textBox and the text.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void password_Click(object sender, EventArgs e)
		{
			passwordRegister.Clear();

			userBarRegister.BackColor = Color.WhiteSmoke;
			usernameRegister.ForeColor = Color.WhiteSmoke;

			passBarRegister.BackColor = Color.FromArgb(3, 174, 218);
			passwordRegister.ForeColor = Color.FromArgb(3, 174, 218);

			confirmPasswordRegister.ForeColor = Color.WhiteSmoke;
			confirmPassBar.BackColor = Color.WhiteSmoke;

			mailBarRegister.BackColor = Color.WhiteSmoke;
			emailRegister.ForeColor = Color.WhiteSmoke;
		}

		/// <summary>
		/// Changes the color of both, the email textBox and the text.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void email_Click(object sender, EventArgs e)
		{
			emailRegister.Clear();

			userBarRegister.BackColor = Color.WhiteSmoke;
			usernameRegister.ForeColor = Color.WhiteSmoke;

			passBarRegister.BackColor = Color.WhiteSmoke;
			passwordRegister.ForeColor = Color.WhiteSmoke;

			confirmPasswordRegister.ForeColor = Color.WhiteSmoke;
			confirmPassBar.BackColor = Color.WhiteSmoke;

			mailBarRegister.BackColor = Color.FromArgb(3, 174, 218);
			emailRegister.ForeColor = Color.FromArgb(3, 174, 218);
		}

		/// <summary>
		/// Shows the main menu of the application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mainMenu_Click(object sender, EventArgs e)
		{
			FormMainMenu Menu = new FormMainMenu();
			this.Hide();
			Menu.ShowDialog();
			this.Close();
		}

		/// <summary>
		/// Changes the color of both, the confirmPAssword textBox and the text.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void confirmPassword_Click(object sender, EventArgs e)
		{
			confirmPasswordRegister.Clear();

			userBarRegister.BackColor = Color.WhiteSmoke;
			usernameRegister.ForeColor = Color.WhiteSmoke;

			passBarRegister.BackColor = Color.WhiteSmoke;
			passwordRegister.ForeColor = Color.WhiteSmoke;

			confirmPasswordRegister.ForeColor = Color.FromArgb(3, 174, 218);
			confirmPassBar.BackColor = Color.FromArgb(3, 174, 218);

			mailBarRegister.BackColor = Color.WhiteSmoke;
			emailRegister.ForeColor = Color.WhiteSmoke;
		}
	}
}

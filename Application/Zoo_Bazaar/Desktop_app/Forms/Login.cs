﻿using DataCL.DTOs;
using Logic;
using LogicCL;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Desktop_app.Forms
{
    public partial class Login : Form
    {
        private LoginService loginService;
        public Login()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        //This is a void for creating the method, someone convert this in a button please.

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            User? loggedInUser = loginService.validateUserCredentials(TB_UsernameLogin.Text, TB_PasswordLogin.Text);

            if (loggedInUser != null)
            {
                //Check if user trying to login to desktop app is employee
                if (loggedInUser.GetType() == typeof(HR))
                {
                    this.Hide();
                    var HR_form = new Human_Resources(loggedInUser);
                    HR_form.ShowDialog();
                    this.Close();
                }


                else if (loggedInUser.GetType() == typeof(Zookeeper))
                {
                    this.Hide();
                    var HR_form = new Zoo_Keeper(loggedInUser);
                    HR_form.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Wrong Credentials");
            }
        }
    }
}




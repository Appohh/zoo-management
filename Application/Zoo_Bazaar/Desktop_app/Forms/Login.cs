using DataCL.DTOs;
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

namespace Desktop_app.Forms
{
    public partial class Login : Form
    {
        UserManagement userManagement;
        public Login()
        {
            InitializeComponent();
            userManagement = new UserManagement();
        }

        //This is a void for creating the method, someone convert this in a button please.
        public void login(string username, string password)
        {

            User? loggedInUser = userManagement.validateUserCredentials(username, password);

            if (loggedInUser != null)
            {
                //Check if user trying to login to desktop app is employee
                if (loggedInUser.GetType() == typeof(Employee))
                {
                    //check what type of employee
                    if (loggedInUser.GetType() == typeof(HR))
                    {
                        //redirect to HR dashboard and pass User
                    }
                    //Add more employee type checks here....

                    else
                    {
                        //let user know they cannot login here with their type of account
                    }
                }

            } else
            {
                //if user is null and there is no user with given credentials
            }
        }
    }
}

using DataCL.DTOs;
using DataCL;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Reflection.Metadata.Ecma335;

namespace LogicCL
{
    public class UserManagement
    {
        private UserDataTraffic userDataTraffic = new UserDataTraffic();
        private List<User> users = new List<User>();

        public UserManagement()
        {
            refreshUserData();
        }


        public void refreshUserData()
        {
            users.Clear();
            //!!!!!!
            //still needs converting from DTO to userfriendly User class with selected fields


            this.userDataTraffic.retrieveUsers();
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> getUserList([Optional] Type type, [Optional] List<Type> types)
        {
            //Returns list of users based on type, able to be provided with one type, a list of types or nothing

            if(types != null)
            {
                List<User> filteredUsers = new List<User>();
                filteredUsers.AddRange(users.Where(user => types.Contains(user.GetType())));
                return filteredUsers;
            }

            if(type != null)
            {
                List<User> filteredUsers = new List<User>();
                filteredUsers.AddRange(users.Where(user => type == user.GetType()));
                return filteredUsers;
            }

            return users;
        }

        public User? validateUserCredentials(string username, string password)
        {
            //validates & returns User that tries to login
            List<User> userFound = new List<User>();
            userFound = (List<User>)users.Where(user => username == user.UserName && password == user.Password);

            if (userFound.Count == 1) return userFound.First(); else { return null; }   
        }

    }
}

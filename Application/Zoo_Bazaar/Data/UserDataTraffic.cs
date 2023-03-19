﻿using DataCL.DTOs;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataCL
{
    public class UserDataTraffic : UserDataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select * from Employees";
            }
        }
        public List<UserDTO> retrieveUsers()
        {
            List<UserDTO> Users = new List<UserDTO>();

            //get datatable of queried data
            DataTable table = base.ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                Users.Add(DataConvertingMethods.ConvertDataRowToObject<UserDTO>(dr));
            }

            //return collection of DTOs
            return Users;
        }

        public void addUser()
        {
            //string query = $"INSERT INTO `Task` (`Name`, `Description`, `StartDate`, `DueDate`, `Cycle`, `PersonId`) VALUES ('{name}', '{description}', '{startdate}', '{duedate}', '{cycle}', '{personid}');";
            //return executeQuery(query);
        }

        public void Update(UserDTO user, int sick)
        {
            //string query = $"UPDATE Animal SET Sick={sick} WHERE Id={}";
            //return executeQuery(query);
        }

    }
}
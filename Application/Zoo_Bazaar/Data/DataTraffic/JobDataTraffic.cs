using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DataTraffic
{
    public class JobDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select * from Jobs";
            }
        }

        public List<JobDTO> retrieveJobs()
        {

            List<JobDTO> jobs = new List<JobDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                jobs.Add(DataConvertingMethods.ConvertDataRowToObject<JobDTO>(dr));
            }

            //return collection of DTOs
            return jobs;
        }
    }
}

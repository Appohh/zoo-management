using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCL.DTOs;

namespace DataCL.DataTraffic
{
    public class DiscountDataTraffic:DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select * from Discount";
            }
        }

        public List<DiscountDTO> retrieveDiscount()
        {

            List<DiscountDTO> discounts = new List<DiscountDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                discounts.Add(DataConvertingMethods.ConvertDataRowToObject<DiscountDTO>(dr));
            }

            //return collection of DTOs
            return discounts;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public List<Tuple<int, int>> Tickets { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public decimal? TotalPrice { get; set; }
        public int Paid { get; set; }
        public decimal Discount { get; set; }
        public OrderDTO(int id, List<Tuple<int, int>> tickets, string name, string email, string phoneNumber, decimal? totalPrice, int paid, decimal discount)
        {
            Id = id;
            Tickets = tickets;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            TotalPrice = totalPrice;
            Paid = paid;
            Discount = discount;
        }
        public OrderDTO()
        {

        }
    }
}

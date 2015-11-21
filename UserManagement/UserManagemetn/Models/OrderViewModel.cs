using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserManagemetn.Models
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public Books Book { get; set; }
        public User User { get; set; }
    }
}
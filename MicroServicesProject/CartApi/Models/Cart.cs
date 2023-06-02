using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartApi.Models
{
    public class Cart
    {
        public int UserID { get; set; } = 1;
        public int ProductID { get; set; }
        public int Price { get; set; }
        public int RequestID { get; set; }
    }
}

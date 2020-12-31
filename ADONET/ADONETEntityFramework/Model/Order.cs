using System;
using System.Collections.Generic;
using System.Text;

namespace ADONETEntityFramework.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string OrderLoc { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

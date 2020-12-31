using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ADONETEntityFramework.Migrations
{
    public class PrintOrderDetailss
    {
        public void PrintOrders()
        {
            using (var context = new EntityContext())
            {
                var order1 = context.Orderss;
                Console.WriteLine("**************Order table*****************");
                foreach (var order2 in order1)
                {
                    Console.WriteLine(order2.OrderId + "  " + order2.OrderName + "  " + order2.OrderLoc);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ADONETEntityFramework.Migrations
{
    public class InsertDataIntoOrders
    {
        public void InsertIntoOrder()
        {
            try
            {
                using (var context = new EntityContext())
                {
                    var order = new Order();
                    //{

                    //    OrderName = "Phone",
                    //    OrderLoc = "Hyderabad",
                    //    ProductId=1
                    //};

                    Console.WriteLine("Enter the OrderName:");
                    order.OrderName = Console.ReadLine();
                    Console.WriteLine("Enter the OrderLocation:");
                    order.OrderLoc = Console.ReadLine();
                    Console.WriteLine("Enter the ProductId:");
                    order.ProductId = int.Parse(Console.ReadLine());
                    context.Orderss.Add(order);
                    context.SaveChanges();
                    Console.WriteLine("Records successfully inserted into orders table.....");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

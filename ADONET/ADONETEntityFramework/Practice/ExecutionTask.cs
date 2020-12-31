using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADONETEntityFramework
{
    public class ExecutionTask
    {
        public void Test()
        {
            using (EntityContext context = new EntityContext())
            {
                var Orders = context.Order;//.Where(d=>d.Cust_Name.StartsWith("s"));

                foreach (var i in Orders)
                {
                    Console.WriteLine(i.Order_Id + "\t|\t" + i.Category);
                }
            }
        }

        public void ListOrders()
        {
            using (EntityContext context = new EntityContext())
            {
                var Orders = context.Order;
                foreach (var order in Orders)
                {
                    Console.WriteLine(order.Order_Id);
                }
            }
        }

        public void AddRowToOrder(int orderid, string category)
        {
            using (EntityContext context = new EntityContext())
            {
                var newRow = new Orderss
                {
                    Order_Id = orderid,
                    Category = category
                };
                context.Order.Add(newRow);
                context.SaveChanges();
            }

        }

        public void UpdateOrderName(int Order_id, string category)
        {
            using (EntityContext context = new EntityContext())
            {
                var orders = context.Order.Where(d => d.Order_Id == Order_id).FirstOrDefault();
                if (orders != null)
                {
                    orders.Category = category;

                    //context.Entry(cust).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();

                    //Stop doing undo

                }

            }
        }

        public void DeleteOrderRow(int order_id)
        {
            using (EntityContext context = new EntityContext())
            {
                var Orders = context.Order.Where(d => d.Order_Id == order_id).FirstOrDefault();
                if (Orders != null)
                {
                    context.Order.Remove(Orders);
                    context.SaveChanges();
                }

            }
        }

        public void OrderWithJoins()
        {
            using (EntityContext context = new EntityContext())
            {
                var data = from product in context.Products
                           join order in context.Order
                           on product.Category equals order.Category
                           select new
                           {
                               Product_Id = product.Product_Id,
                               Visibility = product.Visibility,
                               Order_ID = order.Order_Id
                           };
                foreach (var i in data)
                {
                    Console.WriteLine(i.Product_Id + "   ||   " + i.Visibility + "             ||    " + i.Order_ID);
                }
            }
        }
    }
}

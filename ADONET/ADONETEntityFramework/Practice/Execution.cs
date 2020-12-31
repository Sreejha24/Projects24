using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using static System.Collections.Immutable.ImmutableArray<T>;

namespace ADONETEntityFramework
{
    public class Execution
    {
        //public  void Test()
        //{
        //    using (EntityContext context = new EntityContext())
        //    {
        //        var Customers = context.Customer;//.Where(d=>d.Cust_Name.StartsWith("s"));
              
        //        foreach(var i in Customers)
        //        {
        //            Console.WriteLine(i.AutoId+ "\t|\t" +i.Cust_ID+ "\t|\t" +i.Cust_Name);
        //        }
        //    }
        //}

        //public void ListCustomers()
        //{
        //    using (EntityContext context = new EntityContext())
        //    {
        //        var Customers = context.Customer;
        //        foreach (var customer in Customers)
        //        {
        //            Console.WriteLine(customer.Cust_ID);
        //        }
        //    }
        //}

        //public void AddRowToCustomer(string cid,string cname,string mobile,string loc)
        //{
        //    using (EntityContext context = new EntityContext())
        //    {
        //        var newRow = new Customer
        //        {
        //            Cust_ID = cid,
        //            Cust_Name = cname,
        //            Mobile_No = mobile,
        //            Location = loc

        //        };
        //        context.Customer.Add(newRow);
        //        context.SaveChanges();
        //    }
            
        //}

        //public void UpdateCustomerName(int Cust_id,string Cust_name)
        //{
        //    using(EntityContext context  = new EntityContext())
        //    {
        //        var cust = context.Customer.Where(d=>d.AutoId==Cust_id).FirstOrDefault();
        //        if(cust !=null)
        //        {
        //            cust.Cust_Name = Cust_name;
                   
        //            //context.Entry(cust).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //            context.SaveChanges();
                  
        //            //Stop doing undo

        //        }
               
        //    }
        //}

        //public void DeleteCustomerRow(int Cust_id)
        //{
        //    using (EntityContext context = new EntityContext())
        //    {
        //        var Customers = context.Customer.Where(d => d.AutoId == Cust_id).FirstOrDefault();
        //        if(Customers != null)
        //        {
        //            context.Customer.Remove(Customers);
        //            context.SaveChanges();
        //        }

        //    }
        //}
	
        //public void CustomerWithJoins()
        //{
        //    using (EntityContext context = new EntityContext())
        //    {
        //        var data = from order in context.Orders
        //                   join customer in context.Customer
        //                   on order.Cust_ID equals customer.Cust_ID
        //                   select new
        //                   {
        //                       Cust_ID = order.Cust_ID,
        //                       Cust_Name = customer.Cust_Name,
        //                       Order_ID = order.Order_ID
        //                   };
        //        foreach(var i in data)
        //        {
        //            Console.WriteLine(i.Cust_ID+ "   ||   " +i.Cust_Name+"             ||    "+i.Order_ID);
        //        }
        //    }
        //}
    }
}

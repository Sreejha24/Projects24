using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ADONETEntityFramework
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Order_ID { get; set; }
        public string? Cust_ID { get; set; }
        public string Product_Id { get; set; }
      //  [Order_ID]
      //,[Cust_ID]
      //,[Product_Id]

    }
}

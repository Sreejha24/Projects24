using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ADONETEntityFramework
{
   public  class Customer 
    {
        [Key]
        public string Cust_ID { get; set; }

        public string Cust_Name { get; set; }

        public string Mobile_No { get; set; }

        public string Location { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int AutoId { get; set; }
      //  [Cust_ID]
      //,[Cust_Name]
      //,[Mobile_No]
      //,[Location]
      //,[AutoId]
    }
}

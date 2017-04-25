using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DWD273_Final_Project.Models
{
    public class TicketContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TicketContext() : base("name=DWD273_Final_ProjectContext")
        {
        }

        public System.Data.Entity.DbSet<DWD273_Final_Project.Models.Ticket> Tickets { get; set; }
    }
}

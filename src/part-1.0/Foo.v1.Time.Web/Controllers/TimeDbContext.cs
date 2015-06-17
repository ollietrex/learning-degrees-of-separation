using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Foo.v1.Time.Web.Controllers
{
    public class TimeDbContext : DbContext
    {
        public TimeDbContext() : base("time")
        {
            
        }

        public DbSet<TimeEntity> TimeEntities { get; set; } 
    }
}
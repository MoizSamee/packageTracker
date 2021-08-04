using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageTracker.Data
{
    public class PackageTrackerContext : DbContext
    {
        
            public PackageTrackerContext(DbContextOptions<PackageTrackerContext> options)
                : base(options)
            {
            }

        
        /*public DbSet<RecruitCatSameemz.Pages.Models.Address> Address { get; set; }
*/
        public DbSet<PackageTracker.Models.CustomerInfo> CustomerInfo { get; set; }

        public DbSet<PackageTracker.Models.ShippingInfo> ShippingInfo { get; set; }

            
        
    }
}

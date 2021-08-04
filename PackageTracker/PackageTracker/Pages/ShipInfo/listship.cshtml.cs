using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PackageTracker.Data;
using PackageTracker.Models;

namespace PackageTracker.Pages.ShipInfo
{
    public class listshipModel : PageModel
    {
        private readonly PackageTracker.Data.PackageTrackerContext _context;

        public listshipModel(PackageTracker.Data.PackageTrackerContext context)
        {
            _context = context;
        }

        public IList<ShippingInfo> ShippingInfo { get;set; }

        public async Task OnGetAsync()
        {
            ShippingInfo = await _context.ShippingInfo.ToListAsync();
        }
    }
}

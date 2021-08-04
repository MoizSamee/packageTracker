using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PackageTracker.Data;
using PackageTracker.Models;

namespace PackageTracker.Pages.CustInfo
{
    public class IndexModel : PageModel
    {
        private readonly PackageTracker.Data.PackageTrackerContext _context;

        public IndexModel(PackageTracker.Data.PackageTrackerContext context)
        {
            _context = context;
        }

        public IList<CustomerInfo> CustomerInfo { get;set; }

        public async Task OnGetAsync()
        {
            CustomerInfo = await _context.CustomerInfo.ToListAsync();
        }
    }
}

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
    public class DetailsModel : PageModel
    {
        private readonly PackageTracker.Data.PackageTrackerContext _context;

        public DetailsModel(PackageTracker.Data.PackageTrackerContext context)
        {
            _context = context;
        }

        public CustomerInfo CustomerInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CustomerInfo = await _context.CustomerInfo.FirstOrDefaultAsync(m => m.CustId == id);

            if (CustomerInfo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

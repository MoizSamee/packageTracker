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
    public class DetailsModel : PageModel
    {
        private readonly PackageTracker.Data.PackageTrackerContext _context;

        public DetailsModel(PackageTracker.Data.PackageTrackerContext context)
        {
            _context = context;
        }

        public ShippingInfo ShippingInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ShippingInfo = await _context.ShippingInfo.FirstOrDefaultAsync(m => m.Id == id);

            if (ShippingInfo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

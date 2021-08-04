using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PackageTracker.Data;
using PackageTracker.Models;

namespace PackageTracker.Pages.ShipInfo
{
    public class EditModel : PageModel
    {
        private readonly PackageTracker.Data.PackageTrackerContext _context;

        public EditModel(PackageTracker.Data.PackageTrackerContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ShippingInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShippingInfoExists(ShippingInfo.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ShippingInfoExists(int id)
        {
            return _context.ShippingInfo.Any(e => e.Id == id);
        }
    }
}

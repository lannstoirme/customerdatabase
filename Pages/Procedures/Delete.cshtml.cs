using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MicahCustomerManager.Data;
using MicahCustomerManager.Models;
using Microsoft.AspNetCore.Authorization;

namespace MicahCustomerManager.Pages.Procedures
{
    [Authorize(Policy = "RequireAdministratorRole")]
    public class DeleteModel : PageModel
    {
        private readonly MicahCustomerManager.Data.ApplicationDbContext _context;

        public DeleteModel(MicahCustomerManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Procedure Procedure { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Procedure = await _context.Procedure.FirstOrDefaultAsync(m => m.Id == id);

            if (Procedure == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Procedure = await _context.Procedure.FindAsync(id);

            if (Procedure != null)
            {
                _context.Procedure.Remove(Procedure);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

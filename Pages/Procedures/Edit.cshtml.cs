using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MicahCustomerManager.Data;
using MicahCustomerManager.Models;
using Microsoft.AspNetCore.Authorization;

namespace MicahCustomerManager.Pages.Procedures
{
    [Authorize(Policy = "RequireAdministratorRole")]
    public class EditModel : PageModel
    {
        private readonly MicahCustomerManager.Data.ApplicationDbContext _context;

        public EditModel(MicahCustomerManager.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Procedure).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcedureExists(Procedure.Id))
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

        private bool ProcedureExists(int id)
        {
            return _context.Procedure.Any(e => e.Id == id);
        }
    }
}

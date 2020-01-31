using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MicahCustomerManager.Data;
using MicahCustomerManager.Models;
using Microsoft.AspNetCore.Authorization;

namespace MicahCustomerManager.Pages.Procedures
{
    [Authorize(Policy = "RequireAdministratorRole")]
    public class CreateModel : PageModel
    {
        private readonly MicahCustomerManager.Data.ApplicationDbContext _context;

        public CreateModel(MicahCustomerManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Procedure Procedure { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Procedure.Add(Procedure);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

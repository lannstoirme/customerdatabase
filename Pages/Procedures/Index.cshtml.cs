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
    public class IndexModel : PageModel
    {
        private readonly MicahCustomerManager.Data.ApplicationDbContext _context;

        public IndexModel(MicahCustomerManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Procedure> Procedure { get;set; }

        public async Task OnGetAsync()
        {
            Procedure = await _context.Procedure.ToListAsync();
        }
    }
}

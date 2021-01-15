using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContractsManagement.Data;
using ContractsManagement.Models;

namespace ContractsManagement.Pages.MiningContract
{
    public class CreateModel : PageModel
    {
        private readonly ContractsManagement.Data.ContractsContext _context;

        public CreateModel(ContractsManagement.Data.ContractsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MiningContracts MiningContracts { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MiningContracts.Add(MiningContracts);
            await _context.SaveChangesAsync();
            TempData["Referrer"] = "SaveRegister";

            return RedirectToPage("./Index");
        }
    }
}

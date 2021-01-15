using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContractsManagement.Data;
using ContractsManagement.Models;

namespace ContractsManagement.Pages.MiningContract
{
    public class EditModel : PageModel
    {
        private readonly ContractsManagement.Data.ContractsContext _context;

        public EditModel(ContractsManagement.Data.ContractsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MiningContracts MiningContracts { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MiningContracts = await _context.MiningContracts.FirstOrDefaultAsync(m => m.ID == id);

            if (MiningContracts == null)
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

            _context.Attach(MiningContracts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                TempData["Referrers"] = "Edited";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MiningContractsExists(MiningContracts.ID))
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

        private bool MiningContractsExists(int id)
        {
            return _context.MiningContracts.Any(e => e.ID == id);
        }
    }
}

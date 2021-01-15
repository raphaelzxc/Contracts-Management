using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContractsManagement.Data;
using ContractsManagement.Models;

namespace ContractsManagement.Pages.MiningContract
{
    public class DeleteModel : PageModel
    {
        private readonly ContractsManagement.Data.ContractsContext _context;

        public DeleteModel(ContractsManagement.Data.ContractsContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MiningContracts = await _context.MiningContracts.FindAsync(id);

            if (MiningContracts != null)
            {
                _context.MiningContracts.Remove(MiningContracts);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

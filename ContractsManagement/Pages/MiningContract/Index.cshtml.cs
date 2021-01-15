using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContractsManagement.Data;
using ContractsManagement.Models;
using System.IO;
using OfficeOpenXml;
using Microsoft.Extensions.Logging;

namespace ContractsManagement.Pages.MiningContract
{
    public class IndexModel : PageModel
    {
        private readonly ContractsManagement.Data.ContractsContext _context;

        public IndexModel(ContractsManagement.Data.ContractsContext context)
        {
            _context = context;
        }

        public IEnumerable<MiningContracts> results { get; set; }

        public IList<MiningContracts> MiningContracts { get;set; }

       
        public async Task OnGetAsync(string searchString)
        {
            var Contracts = from m in _context.MiningContracts
                           select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                Contracts = Contracts.Where(s => s.ContractorsName.Contains(searchString));

            }
            MiningContracts = await Contracts.ToListAsync();
         
        }

        public async Task<IActionResult> OnPostExportExcelAsync()
        {

            var myBUs = await _context.MiningContracts.ToListAsync();
            // above code loads the data using LINQ with EF (query of table), you can substitute this with any data source.
            var stream = new MemoryStream();

            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                workSheet.Cells.LoadFromCollection(myBUs, true);
                package.Save();
            }
            stream.Position = 0;

            string excelName = $"MiningContracts-{DateTime.Now}.xlsx";
            // above I define the name of the file using the current datetime.

            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName); // this will be the actual export.
        }

       

    }
}

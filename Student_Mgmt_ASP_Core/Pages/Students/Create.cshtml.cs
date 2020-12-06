using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student_Mgmt_ASP_Core.Data;
using Student_Mgmt_ASP_Core.Model;

namespace Student_Mgmt_ASP_Core.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly Student_Mgmt_ASP_Core.Data.Student_Mgmt_Database _context;

        public CreateModel(Student_Mgmt_ASP_Core.Data.Student_Mgmt_Database context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

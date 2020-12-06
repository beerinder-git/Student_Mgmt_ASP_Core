using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Mgmt_ASP_Core.Data;
using Student_Mgmt_ASP_Core.Model;

namespace Student_Mgmt_ASP_Core.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly Student_Mgmt_ASP_Core.Data.Student_Mgmt_Database _context;

        public DetailsModel(Student_Mgmt_ASP_Core.Data.Student_Mgmt_Database context)
        {
            _context = context;
        }

        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Course.FirstOrDefaultAsync(m => m.course_ID == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

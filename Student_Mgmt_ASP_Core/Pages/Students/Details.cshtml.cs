﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Mgmt_ASP_Core.Data;
using Student_Mgmt_ASP_Core.Model;

namespace Student_Mgmt_ASP_Core.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly Student_Mgmt_ASP_Core.Data.Student_Mgmt_Database _context;

        public DetailsModel(Student_Mgmt_ASP_Core.Data.Student_Mgmt_Database context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.student_ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

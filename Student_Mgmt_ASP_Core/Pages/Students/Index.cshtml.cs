using System;
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
    public class IndexModel : PageModel
    {
        private readonly Student_Mgmt_ASP_Core.Data.Student_Mgmt_Database _context;

        public IndexModel(Student_Mgmt_ASP_Core.Data.Student_Mgmt_Database context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Mgmt_ASP_Core.Model
{
    public class Course
    {
        [Key]
        public int course_ID { get; set; }
        public string course_Name { get; set; }

        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public string course_duration { get; set; }
    }
}

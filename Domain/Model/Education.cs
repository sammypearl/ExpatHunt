using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Education
    {
        public int EduId { get; set; }
        public int ApplicantId { get; set; }
        public string Degree { get; set; }
        public string University { get; set; }
        public float Percentage { get; set; }
        public DateTime GraduationYear { get; set; }

    }
}

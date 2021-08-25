using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Resume
    {
        public int ResumeId { get; set; }
        public string ResumeHeadline { get; set; }
        public int ApplicantId { get; set; }

    }
}

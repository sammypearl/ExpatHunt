using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class JobsAplied
    {
        public int ApplicantId { get; set; }
        public int AppliedId { get; set; }
        public int JobId { get; set; }
        public int ResumeId { get; set; }
        public DateTime AppliedDate { get; set; }

    }
}

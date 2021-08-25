using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class FeedBack
    {
        public int FeedBackId { get; set; }
        public int ApplicantId { get; set; }
        public string Feedback { get; set; }
        public DateTime FeedBackDate { get; set; }
        public Applicant Applicant { get; set; }
    }
}

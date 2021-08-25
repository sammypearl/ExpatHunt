using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int MobilePhone { get; set; }
        public string Degree { get; set; }
        public string CoverLetter { get; set; }
        public string Resume { get; set; }
        public string ProfileStatus { get; set; }


        public string ApplicantPhoto { get; set; }

    }
}

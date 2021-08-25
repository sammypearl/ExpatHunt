using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class JobsEntity
    {
        public int JobId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
        public DateTime LastDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDesc { get; set; }
        public string Website { get; set; }
        public bool Filled { get; set; }
        public List<Applicant> Applicants { get; set; }

        public int CompanyId { get; set; }
        public string JobStatus { get; set; }
        public DateTime DatePosted { get; set; }
        public JobCategory Category { get; set; }
        public string SexPreference { get; set; }
        public string Experience { get; set; }
        public int EmployeesRequired { get; set; }
        public double Salary { get; set; }
        public string JobSector { get; set; }
        public string SkillRequired { get; set; }
        public string EducationReq { get; set; }
        public string BasicReq { get; set; }
        public DateTime JobExpirationDate { get; set; }
      




    }
}

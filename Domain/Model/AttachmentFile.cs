using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class AttachmentFile
    {
        public int FileId { get; set; }
        public int ApplicantId { get; set; }
        public string FileName { get; set; }
        public string FileLocation { get; set; }

    }
}

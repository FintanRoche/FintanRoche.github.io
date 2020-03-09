using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IncidentReportForm.Models
{
    public interface ISubject
    {
        public string SubjectType { get; set; }
        [Key]
        public String Pin { get; set; }
        public String FirstName { get; set; }
        public string LastName { set; get; }

    }
}

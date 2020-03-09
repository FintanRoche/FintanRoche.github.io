using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IncidentReportForm.Models
{
    public class Third : ISubject
    {
        public string SubjectType { get; set; }
        [Key]
        public string Pin { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
    }
}

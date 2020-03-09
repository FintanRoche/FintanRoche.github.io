using IncidentReportForm.Models;
//using IncidentReportForm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidentReportForm.Models
{
    public class DisplayViewModel
    {
        //public ReportRepository reportRepository { get; set; }
        public IEnumerable<Reports> Reports { get; set; }
        public string search {get; set;}
        public string firstName { get; set; }
    }
}

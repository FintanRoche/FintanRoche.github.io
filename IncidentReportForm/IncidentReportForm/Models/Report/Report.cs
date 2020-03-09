using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IncidentReportForm.Models
{
    public class Reports
    {
        [Key]
        public int ReportId { get; set; }
        public string IncidentType { get; set; }
       // public IEnumerable<SelectListItem> IncidentTypes { get; set; }
        public bool PRNBool { get; set; }
        public string PRN_Medication { get; set; }
        public Principal Principal { get; set; }
        public Secondary Secondary { get; set; }
        public Third Third { get; set; }
        public string ManagementUnit { get; set; }
        public string CentreName { get; set; }
        public string CostCentre { get; set; }
        public string ServiceType { get; set; }
        public string IncidentDescription { get; set; }
        public string IncidentLocation { get; set; }
        public string IncidentRoom { get; set; }
        public string PersonPresent { get; set; }
        public string ConnectedIncidentDetails { get; set; }
        public bool Abuse { get; set; }
        public string MedicalIntervention { get; set; }
        public string Serverity { get; set; }
        public string Manageabillity { get; set; }
        public string Frequency { get; set; }
        public string ContributingFactors { get; set; }
        public string Solutions { get; set; }
        public string ManagerEmail { get; set; }  
        //public Options Options { get; set; }
        public IdentityUser User { get; set; }

        // public DateTime OrderPlaced { get; set; }
    }
}

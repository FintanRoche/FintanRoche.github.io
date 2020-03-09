using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IncidentReportForm.Models
{
    public class Options
    {
        public static List<string> IncidentType = new List<string>() { "Sample A", "Sample B" };
        public static List<string> SubjectType = new List<string>() { "Service User", "Staff Member", "Member of Public", "other" };
        public static List<string> Pin = new List<string>() { "Sample A", "Sample B" };
        public static List<string> ManagmentUnit = new List<string>() { "Sample A", "Sample B" };
        public static List<string> CentreName = new List<string>() { "Sample A", "Sample B" };
        public static List<string> CostCentre = new List<string>() { "Sample A", "Sample B" };
        public static List<string> ServiceType = new List<string>() { "Sample A", "Sample B" };
       


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidentReportForm.Models
{
    public interface IReportRepository
    {
        IEnumerable<Reports> AllReports { get; }

        void CreateReport(Reports report);
        Reports GetReportById(int reportId);
    }
}

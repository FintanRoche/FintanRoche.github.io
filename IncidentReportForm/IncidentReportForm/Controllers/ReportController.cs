using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IncidentReportForm.Models;
//using IncidentReportForm.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IncidentReportForm.Controllers
{
    [Authorize]
    public class ReportController : Controller
       
    {
        
        private readonly ILogger<ReportController> _logger;
        
        private readonly IReportRepository _reportRepository;
        public ReportController(IReportRepository reportRepository)
        {

            _reportRepository = reportRepository;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Display()
        {
            var displayViewModel = new DisplayViewModel
            {
                Reports = _reportRepository.AllReports
            };


            return View(displayViewModel);

        }

        public IActionResult Search()
        {


            return View();
        }

        [HttpPost]
        public IActionResult SearchResults(Reports report)
        {
            if (!String.IsNullOrEmpty(report.PRN_Medication))
            {
                var displayViewModel = new DisplayViewModel
                {
                    Reports = _reportRepository.AllReports,
                    search = report.PRN_Medication,
                    firstName = report.Principal.FirstName
                };
                return View(displayViewModel);
            }

            return View("Search");
        }


        [HttpPost]
        public IActionResult Checkout(Reports report)
        {
            _reportRepository.CreateReport(report);
            return View(report);
        }

        public IActionResult Details(int reportid)
        {
            var report = _reportRepository.GetReportById(reportid);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }




       
        [HttpPost]
        public IActionResult FormPage2(Reports report)
        {
            
            return View(report);
        }
        [HttpPost]
        public IActionResult Submit(Reports report)
        {
            _reportRepository.CreateReport(report);
            return View(report);
        }


    }
}
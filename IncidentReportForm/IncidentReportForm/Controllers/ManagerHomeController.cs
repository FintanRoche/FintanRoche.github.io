using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IncidentReportForm.Controllers
{
    public class ManagerHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Niketsoni.Models;

namespace Niketsoni.Controllers
{
    public class WorksController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}

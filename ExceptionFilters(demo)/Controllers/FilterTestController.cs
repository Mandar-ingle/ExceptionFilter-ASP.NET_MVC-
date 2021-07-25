using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionFilters_demo_.Controllers
{
    public class FilterTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GenerateError()
        {
            throw new NotImplementedException();
        }
    }
}

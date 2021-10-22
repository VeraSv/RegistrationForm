using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace RegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
          return View("Index", "Home");
            // return Content(User.Identity.Name);
        }
        public IActionResult Main()
        {
            return View("Main");
            // return Content(User.Identity.Name);
        }

    }
}

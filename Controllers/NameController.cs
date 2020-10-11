using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api_test.Models;
 
namespace api_test.Controllers
{
 public class NameController : Controller
    {
        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Save(ApiModel apimodel)
        {
            //saving name into the databse
            return Ok();
        }

        public IActionResult ApiView()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class AccordionController : Controller
    {
        // GET: /<controller>/
        public IActionResult KeyboardInteraction()
        {
            return View();
        }
    }
}
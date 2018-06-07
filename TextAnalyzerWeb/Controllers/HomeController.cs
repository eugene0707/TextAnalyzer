using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextAnalyzerShared.Utils;
using TextAnalyzerShared.Core;
using TextAnalyzerWeb.Models;

namespace TextAnalyzerWeb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [ActionName("Index")]
        [HttpPost]
        public IActionResult Analyze(string sourceText)
        {
            ViewData["sourceText"] = sourceText;
            ViewData["metricResults"] = Starter.RunAnalyzer(new StringBuilder(sourceText));
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

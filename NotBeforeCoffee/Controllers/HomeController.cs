using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotBeforeCoffee.Models;

namespace NotBeforeCoffee.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ERIEPay()
        {
            return View();
        }

        public IActionResult Claim()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult IDCard()
        {
            return View();
        }

        public IActionResult Alert()
        {
            return View();
        }

        public IActionResult Autopay()
        {
            return View();
        }
        public IActionResult Billing()
        {
            return View();
        }
        public IActionResult ChatBot()
        {
            return View();
        }
        public IActionResult CustContact()
        {
            return View();
        }
        public IActionResult Documents()
        {
            return View();
        }
        public IActionResult AgentNow()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using CLDV6212_ST10267383.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CLDV6212_ST10267383.Controllers
{
    public class HomeController : Controller //(IIE, 2024)
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact() 
        {
            return View();
        }
    }

    public class ProductController : Controller
    {
        public IActionResult Index() //(IIE, 2024)
        {
            return View();
        }
    }

    public class OrderController : Controller
    {
        public IActionResult Index() //(IIE, 2024)
        {
            return View();
        }
    }
} //References
  //mdn, 2022. mdn web docs. [Online] 
//Available at: https://developer.mozilla.org/en-US/docs/Web/CSS
//[Accessed 27 August 2024].
//W3Schools, 2018.W3Schools. [Online]
//Available at: https://www.w3schools.com/css/css_intro.asp
//[Accessed 27 August 2024].
//IIE, 2024.Module Manual. 1st ed. Pretoria: IIE Varsity College..
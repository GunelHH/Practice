using System;
using Microsoft.AspNetCore.Mvc;

namespace First_practice.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            ViewResult view = new ViewResult();

            view.ViewName = "About";
            return view;
        }
        public ActionResult Faq()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace master_page_demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult About_game()
        {
            return View("About_game");
        }
        public ActionResult contact_game()
        {
            return View("contact_game");
        }
        [HttpGet]
        public ViewResult Membership()
        {
            return View();
        }
        public ViewResult game2()
        {
            return View("game2");
        }
        [HttpPost]
        public ViewResult Membership(master_page_demo.Models.Member formdata)
        {
            //database
            return View("Thanks", formdata);
        }
        [HttpGet]
        public ViewResult login_page()
        {
            //Models.Member loginModel = new Models.Member();
            return View("login_page");
        }
       [HttpPost]
        public ViewResult login_page(master_page_demo.Models.Member logindata)
        {
            if (logindata.email_id == "jyoti.kumari@gmail.com" && logindata.password == "1234")

                return View("conformation", logindata);
            else
            {
                ViewBag.Message = "login not sucessfull check id and password";
                return View("login_page");
            }
        }
    }
}
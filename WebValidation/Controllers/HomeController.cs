using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation;
using WebValidation.Models;

namespace WebValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// Get data from user
        /// </summary>
        /// <param name="logInInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(LoginModel logInInfo)
        {
            string message = "";

            if (!(string.IsNullOrEmpty(logInInfo.Login) && string.IsNullOrEmpty(logInInfo.Password)))
            {
                 
                if (Program.IsValid(logInInfo.Login, logInInfo.Password)) // Validation
                {
                    message = "true - successful validation";
                }
                else
                    message = "false - validation failed";
            }
            else
            {
                message = "false - login or password is null or empty";
            }
            ViewData["Message"] = message;
            return View("Index");
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}
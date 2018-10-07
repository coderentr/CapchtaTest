using CapchaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapchaTest.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            Random r = new Random();
            int a, b, c;
            Char[] Chr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'Y', 'Z' };
            int ran1 = r.Next(0, Chr.Length);
            char Harf1 = Chr[ran1];
            int ran2 = r.Next(0, Chr.Length);
            Char Harf2 = Chr[ran2];
            a = r.Next(1, 10);
            b = r.Next(1, 10);
            c = r.Next(1, 10);
            string Txt = a.ToString() + Harf1 + b.ToString() + Harf2 + c.ToString();
            ViewBag.Code = Txt;
            return View();
        }
        //[HttpPost]
        //public JsonResult Login(LoginModel model)
        //{
        //    var result = false;
        //    if (model.UserName == "coderen" && model.Password == "12345" && model.Code == model.WriteCode)
        //    {
        //        result = true;
        //    }
        //    else result = false;

        //    return Json(new {result },JsonRequestBehavior.AllowGet);
        //}
    }
}
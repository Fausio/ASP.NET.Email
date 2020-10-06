using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ASP.NET.Email.Controllers
{
    public class EmailController : Controller
    {
        public ActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(string UserMail)
        {
           
            string subject = "titulo do email";
            string body = "corpo do email";
            WebMail.Send(UserMail, subject, body, null, null, null, true, null, null, null, null, null, null);
            ViewBag.msg = "Email enviado com sucesso!";
            return View();
        }
    }
}
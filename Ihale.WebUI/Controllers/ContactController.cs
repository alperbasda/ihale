using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ihale.WebUI.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult MailApprove()
        {
            return View();
        }

        public ActionResult TelephoneApprove()
        {
            return View();
        }
    }
}
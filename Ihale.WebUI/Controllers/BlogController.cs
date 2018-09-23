using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ihale.WebUI.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult HomePageBlogPartial()
        {
            return PartialView();
        }

        public ActionResult Blogs()
        {
            return View();
        }

        public ActionResult BlogDetail()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ihale.WebUI.Controllers
{
    public class SliderImageController : Controller
    {
        // GET: SliderImage
        [ChildActionOnly]
        public ActionResult SliderPartial()
        {
            return PartialView();
        }
    }
}
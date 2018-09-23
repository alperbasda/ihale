using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ihale.WebUI.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult HomePagePaidAuctions()
        {
            return PartialView();
        }

        public ActionResult HomePageBreakingAuctions()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult CategoryInAuctions()
        {
            return PartialView();
        }

        public ActionResult AuctionDetail()
        {
            return View();
        }

        public ActionResult Auctions()
        {
            return View();
        }

        public ActionResult NewAuction()
        {
            return View();
        }
    }
}
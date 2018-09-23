using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ihale.WebUI.Controllers
{
    public class OfferController : Controller
    {
        // GET: Offer
        public ActionResult Offers()
        {
            return View();
        }

        public ActionResult AuctionOffers()
        {
            return View();
        }

        public ActionResult DetailOffer()
        {
            return View();
        }
    }
}
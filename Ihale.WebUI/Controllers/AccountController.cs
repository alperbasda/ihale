using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ihale.Business.Abstract;
using Ihale.Core.Aspects.AuthorizationAspects;
using Ihale.Entity.ComplexType.PostModels;
using Ihale.Entity.Concrete;

namespace Ihale.WebUI.Controllers
{
    public class AccountController : Controller
    {
        
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            //_userService.Login(userName, password, false);
            return RedirectToAction("Profil", "Account");
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            //BaseResponse response = _userService.Register(model);
            //if (response.Success)
            //    return RedirectToAction("Profil", "Account");

            //ViewBag.message = response.Message;
            return View();
        }

        //[SecuredOperationUi(Roles="User")]
        public ActionResult Profil()
        {
            //_userService.GetUserData()
            return View();
        }

        //[SecuredOperationUi(Roles = "User")]
        public ActionResult SetProfile(User user)
        {
            //ViewBag.message = _userService.SetUserData(user).Message;
            return RedirectToAction("Profil", "Account");
        }

        //[SecuredOperationUi(Roles = "User")]
        public ActionResult SetPassword()
        {
            return View();
        }

        //[SecuredOperationUi(Roles = "User")]
        [HttpPost]
        public ActionResult SetPassword(string newPassword,string newConfirm,string oldPassword)
        {
            //ViewBag.message = _userService.SetUserPassword(newPassword,newConfirm,oldPassword).Message;
            return RedirectToAction("Profil", "Account");
        }
        [ChildActionOnly]
        public ActionResult RightPartial()
        {
            return PartialView();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            return View();
        }

        public ActionResult ForgetPassword()
        {
            return View();
        }

        public ActionResult NewPasswordF()
        {
            return View();
        }

    }
}
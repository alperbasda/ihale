using System;
using System.Linq;
using System.Web;
using System.Web.Security;
using Ihale.Business.Abstract;
using Ihale.Core.Aspects.AuthorizationAspects;
using Ihale.Core.CrossCuttingConcerns.Security;
using Ihale.Core.CrossCuttingConcerns.Security.Web;
using Ihale.DataAccess.Abstract;
using Ihale.Entity.Concrete;

namespace Ihale.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        //private IUserDal _userDal;

        //public UserManager(IUserDal userDal)
        //{
        //    _userDal = userDal;
        //}

        //public void Login(string userName, string password, bool rememberMe)
        //{
        //    User user = GetByUserNameAndPassword(userName, password);
        //    if (user != null)
        //        AuthenticationHelper.CreateAuthCookie(user.UserName, user.Mail, DateTime.Now.AddDays(1), _userDal.GetUserRoles(user.Id).Select(s => s.Name).ToArray(), rememberMe, user.FirstName, user.LastName, user.Id);
        //}

        //public BaseResponse Register(RegisterModel model)
        //{
        //    if (!ValidatePassword(model.Password, model.PasswordConfirm)) return Response.PasswordConfirmError();
        //    if (!UsingMail(model.Mail)) return Response.SameMailError();
        //    if (!UsingUserName(model.UserName)) return Response.SameUserNameError();

        //    User user = _userDal.Add(new User
        //    {
        //        FirstName = model.FirstName,
        //        LastName = model.LastName,
        //        Mail = model.Mail,
        //        UserName = model.UserName,
        //        Password = model.Password,
        //        BirthDay = new DateTime(1919, 05, 19)

        //    });
        //    _userDal.SetUserRole(user.Id, 2);
        //    return Response.Success(user.Id);
        //}

        //public void LogOut()
        //{
        //    FormsAuthentication.SignOut();
        //    if (HttpContext.Current.Response.Cookies[FormsAuthentication.FormsCookieName] != null)
        //        HttpContext.Current.Response.Cookies[FormsAuthentication.FormsCookieName].Expires = DateTime.Now.AddDays(-1);
        //}

        //[SecuredOperationAspect(Roles = "User")]
        //public bool ChangeProfilePic(string path)
        //{
        //    int id = GetIdentity().Id;
        //    //User password geliyor sistem açığı...
        //    User user = _userDal.Get(s => s.Id == id);
        //    user.ProfileImagePath = path;
        //    _userDal.Update(user);
        //    return true;
        //}

        //[SecuredOperationAspect(Roles = "User")]
        //public User GetUserData()
        //{
        //    int id = GetIdentity().Id;
        //    User user = _userDal.Get(s => s.Id == id);
        //    user.Password = "";
        //    return user;
        //}

        //[SecuredOperationAspect(Roles = "User")]
        //public BaseResponse SetUserData(User userModel)
        //{
        //    if (!UsingMail(userModel.Mail)) return Response.SameMailError();
        //    int id = GetIdentity().Id;
        //    User user = _userDal.Get(s => s.Id == id);
        //    user.Mail = userModel.Mail;
        //    user.Telephone = userModel.Telephone;
        //    user.FirstName = userModel.FirstName;
        //    user.LastName = userModel.LastName;
        //    user.Gender = userModel.Gender;
        //    user.Address = userModel.Address;
        //    user.City = userModel.City;
        //    user.BirthDay = userModel.BirthDay;
        //    _userDal.Update(user);
        //    return Response.Success(user.Id);
        //}

        //[SecuredOperationAspect(Roles = "User")]
        //public BaseResponse SetUserPassword(string newPassword, string newConfirm, string oldPassword)
        //{
        //    if (!ValidatePassword(newPassword, newConfirm))
        //        return Response.PasswordConfirmError();
        //    int id = GetIdentity().Id;
        //    User user = _userDal.Get(s => s.Id == id);
        //    if (user.Password != oldPassword)
        //        return Response.PasswordWrongError();
        //    user.Password = newPassword;
        //    _userDal.Update(user);
        //    return Response.Success(user.Id);

        //}


        //private User GetByUserNameAndPassword(string userName, string password)
        //{
        //    User user = _userDal.Get(s => s.UserName == userName & s.Password == password);
        //    if (user == null)
        //        return null;
        //    return user;
        //}

        //private bool UsingMail(string mail)
        //{
        //    return _userDal.Get(s => s.Mail == mail) == null;
        //}
        //private bool UsingUserName(string userName)
        //{
        //    return _userDal.Get(s => s.UserName == userName) == null;
        //}
        //private bool ValidatePassword(string password, string passwordConfirm)
        //{
        //    return password == passwordConfirm;
        //}

        //private Identity GetIdentity()
        //{
        //    try
        //    {

        //        var authCookie = System.Web.HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
        //        var encTicket = authCookie.Value;
        //        var ticket = FormsAuthentication.Decrypt(encTicket);
        //        var securityUtilities = new SecurityUtilities();
        //        return securityUtilities.FormAuthToIdentity(ticket);

        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //    }
        //}
    }
}
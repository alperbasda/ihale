using System;
using System.Web.Mvc;
using System.Web.Routing;
using PostSharp.Extensibility;

namespace Ihale.Core.Aspects.AuthorizationAspects
{
    [MulticastAttributeUsage(MulticastTargets.Method, TargetExternalMemberAttributes = MulticastAttributes.Instance)]
    [Serializable]
    public class SecuredOperationUi : ActionFilterAttribute, IAuthorizationFilter
    {
        public string Roles { get; set; }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            string[] roles = Roles.Split(',');
            bool isAuthorize = false;
            for (int i = 0; i < roles.Length; i++)
            {
                if (System.Threading.Thread.CurrentPrincipal.IsInRole(roles[i]))
                {
                    isAuthorize = true;
                }
            }

            if (isAuthorize == false)
            {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary
                        {
                            {"action", "Login"},
                            {"controller", "Home"}
                        });   
            }

        }
    }
}

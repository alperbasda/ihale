
using System;
using System.Security;
using PostSharp.Aspects;
using PostSharp.Extensibility;

namespace Ihale.Core.Aspects.AuthorizationAspects
{
    [MulticastAttributeUsage(MulticastTargets.Method, TargetExternalMemberAttributes = MulticastAttributes.Instance)]
    [Serializable]
    public class SecuredOperationAspect : OnMethodBoundaryAspect
    {
        public string Roles { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
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
                throw new SecurityException("You are not authorized!");
            }

        }
    }
}
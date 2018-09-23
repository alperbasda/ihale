using System;
using System.Linq;
using System.Web.Security;

namespace Ihale.Core.CrossCuttingConcerns.Security.Web
{
    public class SecurityUtilities
    {
        public Identity FormAuthToIdentity(FormsAuthenticationTicket ticket)
        {
            var identity = new Identity
            {
                Name = SetName(ticket),
                Roles = SetRoles(ticket),
                FirstName = SetFirstName(ticket),
                LastName = SetLastName(ticket),
                AuthenticationType = SetAuthType(),
                IsAuthenticated = SetIsAuthenticated(),
                Mail = SetMail(ticket),
                Id = Convert.ToInt32(SetId(ticket)),
            };

            return identity;
        }

        private bool SetIsAuthenticated()
        {
            return true;
        }

        private string SetAuthType()
        {
            return "Forms";
        }

        private string SetLastName(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[3];
        }
        private string SetMail(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[0];
        }

        private string SetId(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[4];
        }

        private string SetFirstName(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[2];
        }

        private string[] SetRoles(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        private string SetName(FormsAuthenticationTicket ticket)
        {
            return ticket.Name;
        }
    }
}
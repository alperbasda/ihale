using System.Security.Principal;

namespace Ihale.Core.CrossCuttingConcerns.Security
{
    public class Identity : IIdentity
    {
        public string Name { get; set; }

        public string Mail { get; set; }

        public string AuthenticationType { get; set; }

        public bool IsAuthenticated { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public string[] Roles { get; set; }
    }
}
namespace Ihale.Entity.ComplexType.PostModels
{
    public class RegisterModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Mail { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

        public bool Newsletter { get; set; }

        public bool Policy { get; set; }
        
    }
}
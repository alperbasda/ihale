namespace Ihale.Entity.ComplexType.PostModels
{
    public class PasswordChangeModel : IViewModel
    {
        public string OldPassword { get; set; }

        public string NewPassword { get; set; }

        public string NewPasswordConfirm { get; set; }
    }
}
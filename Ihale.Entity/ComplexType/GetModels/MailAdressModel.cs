namespace Ihale.Entity.ComplexType.GetModels
{
    public class MailAdressModel : IViewModel
    {
        public int MailAdressId { get; set; }

        public string MailAdress { get; set; }

        public bool MailUsing { get; set; }
                    
        public bool MailAproved { get; set; }
    }
}
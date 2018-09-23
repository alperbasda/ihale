namespace Ihale.Entity.ComplexType.PostModels
{
    public class ContactPostModel : IViewModel
    {
        public string Adress { get; set; }

        public int CityId { get; set; }

        public string Telephone { get; set; }

        public string MailAdress { get; set; }
    }
}
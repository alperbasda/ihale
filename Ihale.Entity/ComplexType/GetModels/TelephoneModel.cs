namespace Ihale.Entity.ComplexType.GetModels
{
    public class TelephoneModel : IViewModel
    {
        public int TelephoneId { get; set; }

        public string Telephone { get; set; }

        public bool TelephoneUsing { get; set; }

        public bool TelephoneAproved { get; set; }
    }
}
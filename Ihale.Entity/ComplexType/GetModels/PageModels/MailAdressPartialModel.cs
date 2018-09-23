using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class MailAdressPartialModel : IViewModel
    {
        public IEnumerable<MailAdressModel> MailAdressModels { get; set; }
    }
}
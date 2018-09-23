using System;
using Ihale.Entity.Concrete;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class ProfileSummaryModel : IViewModel
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public DateTime BirthDay { get; set; }

        public Gender Gender { get; set; }

        public string PaymentAddress { get; set; }

        public string CargoAddress { get; set; }

        public string Telephone { get; set; }

        public string MailAddress { get; set; }

        public bool Notification { get; set; }
    }
}
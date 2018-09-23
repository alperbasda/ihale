using System;
using Ihale.Entity.Concrete;

namespace Ihale.Entity.ComplexType.PostModels
{
    public class ProfileSummaryPostModel : IViewModel
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public Gender Gender { get; set; }

        public DateTime BirthDay { get; set; }
    }
}
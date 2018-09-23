using System;

namespace Ihale.Entity.ComplexType.GetModels
{
    public class BlogShowModel : IViewModel
    {
        public int BlogId { get; set; }

        public DateTime UpdateDate { get; set; }

        public string BlogSummary { get; set; }

        public int CommentCount { get; set; }

        public string BlogImageUrl { get; set; }
    }
}
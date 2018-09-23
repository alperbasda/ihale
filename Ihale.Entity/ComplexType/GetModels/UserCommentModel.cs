using System;

namespace Ihale.Entity.ComplexType.GetModels
{
    public class UserCommentModel : IViewModel
    {
        public int CommentId { get; set; }

        public string UserCommentRate { get; set; }

        public DateTime CommentDate { get; set; }

        public string Comment { get; set; }

    }
}
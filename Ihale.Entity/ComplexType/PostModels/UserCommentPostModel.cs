namespace Ihale.Entity.ComplexType.PostModels
{
    public class UserCommentPostModel : IViewModel
    {
        public int UserId { get; set; }

        public int Rate { get; set; }

        public string Comment { get; set; }
    }
}
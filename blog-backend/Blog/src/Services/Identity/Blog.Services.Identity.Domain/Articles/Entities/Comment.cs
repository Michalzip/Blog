using Blog.Services.Identity.Domain.Users.Entities;

namespace Blog.Services.Identity.Domain.Articles.Entities
{
    internal sealed class Comment
    {
        public Guid ArticleId { get; set; }
        public Article Article { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
    }
}

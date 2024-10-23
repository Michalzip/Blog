namespace Blog.Services.Identity.Domain.Articles.Entities
{
    internal sealed class Article
    {
        public string Header { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
        public bool Visible { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public DateTimeOffset? UpdateDate { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
}

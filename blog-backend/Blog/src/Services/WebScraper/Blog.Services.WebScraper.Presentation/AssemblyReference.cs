using System.Reflection;

namespace Blog.Services.WebScraper.Presentation
{
    public static class AssemblyReference
    {
        public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
    }
}

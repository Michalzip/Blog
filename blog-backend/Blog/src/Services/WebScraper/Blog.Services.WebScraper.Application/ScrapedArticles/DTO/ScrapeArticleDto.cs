namespace Blog.Services.WebScraper.Application.ScrapedArticles.DTO;

public record  ScrapeArticleDto
{
    public List<ScrapeArticleByServiceDto> Articles { get; set; }
}
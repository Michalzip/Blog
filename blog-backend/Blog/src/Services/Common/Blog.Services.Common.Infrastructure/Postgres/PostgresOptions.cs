using Microsoft.Extensions.DependencyInjection;

namespace Blog.Services.Common.Infrastructure.Postgres;

internal  class PostgresOptions
{
public string ConnectionString { get; set; }
}
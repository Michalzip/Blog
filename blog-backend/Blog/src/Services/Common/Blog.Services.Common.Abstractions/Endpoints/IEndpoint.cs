using Microsoft.AspNetCore.Routing;

namespace Blog.Services.Common.Abstractions.Endpoints
{
    public interface IEndpoint
    {
        void MapEndpoint(IEndpointRouteBuilder app);
    }
}

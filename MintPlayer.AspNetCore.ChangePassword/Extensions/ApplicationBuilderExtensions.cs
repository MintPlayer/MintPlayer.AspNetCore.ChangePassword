using Microsoft.AspNetCore.Mvc;

namespace MintPlayer.AspNetCore.ChangePassword.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IEndpointRouteBuilder MapChangePassword(this IEndpointRouteBuilder endpointRouteBuilder, string changePasswordUrl)
        {
            endpointRouteBuilder.MapGet("/.well-known/change-password", (context) =>
            {
                context.Response.Redirect(changePasswordUrl);
                return Task.CompletedTask;
            });
            return endpointRouteBuilder;
        }
    }
}

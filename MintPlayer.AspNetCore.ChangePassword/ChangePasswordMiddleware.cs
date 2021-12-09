using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MintPlayer.AspNetCore.ChangePassword
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ChangePasswordMiddleware
    {
        private readonly RequestDelegate next;
        public ChangePasswordMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return next(httpContext);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters
{
    public class AuthorizationFilter : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var result = false;
            // Simulate a simple authorization check
            
            if (!result)
            {
                context.Result = new UnauthorizedResult(); // Denies access
            }
        }
    }
}

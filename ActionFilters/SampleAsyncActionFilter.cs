using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters
{
    public class SampleAsyncActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(
            ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // Do something before the action executes.
            Console.WriteLine("Started OnActionExecutionAsync");
            
            await next();

            Console.WriteLine("Finished OnActionExecutionAsync");
            // Do something after the action executes.
        }
    }
}

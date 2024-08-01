using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters
{
    public class SampleActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("OnActionExecuted called!!!");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("OnActionExecuting called!!!");
        }
    }
}

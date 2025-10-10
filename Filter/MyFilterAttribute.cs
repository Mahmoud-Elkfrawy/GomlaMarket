using Microsoft.AspNetCore.Mvc.Filters;

namespace GomlaMarket.Filter
{
    public class MyFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("After Excuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("During Excuted");

        }
    }
}

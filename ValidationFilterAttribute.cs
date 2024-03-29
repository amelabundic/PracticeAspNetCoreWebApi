using System;

namespace ActionFilters
{
	public class ValidationFilterAttribute : IActionFilter
	{
	  private readonly ILoggerManager _logger;
      public ValidationFilterAttribute(ILoggerManager logger)
       {
        _logger = logger;
       }

       public void OnActionExecuting(ActionExecutingContext context) { }
       public void OnActionExecuted(ActionExecutedContext context) { }

}
}

using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace MyCompany.ActionFilters
{
	public class ActionFilterExample : IActionFilter
	{
        private readonly ILoggerManager _logger;
        public ActionFilterExample(ILoggerManager logger)
        {
            _logger = logger;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
           

        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
       
         }

}
}

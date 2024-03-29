using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace MyCompany.ActionFilters
{
	public  class ActionFilterAttribute : Attribute, IActionFilter, IFilterMetadata, IAsyncActionFilter, IResultFilter, IAsyncResultFilter, IOrderedFilter
    {
        public int Order => throw new NotImplementedException();

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }

        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            throw new NotImplementedException();
        }

        public Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}

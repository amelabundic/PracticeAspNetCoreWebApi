using System;

namespace ActionFilters
{
	public abstact class ActionFilterAttribute : Attribute, IActionFilter,IFilterMetadata, IAsyncActionFilter, IResultFilter, IAsyncResultFilter, IOrderedFilter
    {

	}
}

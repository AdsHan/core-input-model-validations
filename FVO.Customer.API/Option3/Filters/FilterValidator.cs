using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace FVO.Customer.API.Option3.Filters
{
    public class FilterValidator : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //throw new System.NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var messagesErros = context.ModelState
                    .SelectMany(ms => ms.Value.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                context.Result = new BadRequestObjectResult(messagesErros);
            }
        }
    }
}

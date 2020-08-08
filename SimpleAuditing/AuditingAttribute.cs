using System;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SimpleAuditing
{
    public class AuditingAttribute : ActionFilterAttribute
    {
        private readonly string field;

        public AuditingAttribute(string field = "*")
        {
            this.field = field;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            
            var arg = context.ActionArguments["name"] as dynamic;
                         
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            
            base.OnActionExecuted(context);
        }
    }
}

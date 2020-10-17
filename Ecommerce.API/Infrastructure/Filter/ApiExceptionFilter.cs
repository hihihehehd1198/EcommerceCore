using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Ecommerce.Portal.Infrastructure.Filter
{
    public class ApiExceptionFilter : System.Web.Http.Filters.ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {

        }
    }
}

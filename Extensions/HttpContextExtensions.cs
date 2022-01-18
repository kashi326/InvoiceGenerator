using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenerator.Extensions
{
    public static class HttpContextExtensions
    {
        public static string GetUserName(this HttpContext httpContext)
        {
            return httpContext.User?.Identity?.Name;
        }
    }
}

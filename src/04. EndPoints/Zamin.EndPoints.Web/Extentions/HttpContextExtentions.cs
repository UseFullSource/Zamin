﻿using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.ApplicationServices.Events;
using Zamin.Core.ApplicationServices.Queries;
using Microsoft.AspNetCore.Http;
using Zamin.Toolkits;

namespace Zamin.EndPoints.Web.Extentions
{
    public static class HttpContextExtentions
    {
        public static ICommandDispatcher CommandDispatcher(this HttpContext httpContext) =>
            (ICommandDispatcher)httpContext.RequestServices.GetService(typeof(ICommandDispatcher));

        public static IQueryDispatcher QueryDispatcher(this HttpContext httpContext) =>
            (IQueryDispatcher)httpContext.RequestServices.GetService(typeof(IQueryDispatcher));
        public static IEventDispatcher EventDispatcher(this HttpContext httpContext) =>
            (IEventDispatcher)httpContext.RequestServices.GetService(typeof(IEventDispatcher));
        public static ZaminServices ZaminApplicationContext(this HttpContext httpContext) =>
            (ZaminServices)httpContext.RequestServices.GetService(typeof(ZaminServices));
    }
}

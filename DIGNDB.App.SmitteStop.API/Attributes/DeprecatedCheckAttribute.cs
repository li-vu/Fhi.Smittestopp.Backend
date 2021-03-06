﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Net;

namespace DIGNDB.App.SmitteStop.API.Attributes
{
    public class DeprecatedCheckAttribute : ActionFilterAttribute
    {
        private List<string> DeprecatedVersions { get; } = new List<string>();

        public DeprecatedCheckAttribute(AppSettingsConfig appSettingsConfig)
        {
            DeprecatedVersions = appSettingsConfig.DeprecatedVersions;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var requestedApiVersion = context.HttpContext.GetRequestedApiVersion()?.ToString();

            if (DeprecatedVersions.Contains(requestedApiVersion))
            {
                context.Result = new ContentResult
                {
                    Content = "API is deprecated",
                    StatusCode = (int?)HttpStatusCode.Gone
                };
            }
        }
    }
}
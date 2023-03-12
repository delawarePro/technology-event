using System;
using Microsoft.AspNetCore.Components;
using System.Collections.Specialized;
using System.Web;

namespace dte.wall.Helpers
{
    public static class NavigationExtensions
    {
        /// <summary>
        /// Get the querystring as key/value pairs
        /// </summary>
        /// <param name="navigationManager">The navigation manager</param>
        /// <returns></returns>
        public static NameValueCollection QueryString(this NavigationManager navigationManager)
        {
            return HttpUtility.ParseQueryString(new Uri(navigationManager.Uri).Query);
        }

        /// <summary>
        /// Get value from querystring
        /// </summary>
        /// <param name="navigationManager">The navigation manager</param>
        /// <param name="key">The key to get the value from</param>
        /// <returns></returns>
        public static string? QueryString(this NavigationManager navigationManager, string key)
        {
            return navigationManager.QueryString()[key];
        }
    }
}


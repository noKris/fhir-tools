﻿using System;

namespace FhirTool.Extensions
{
    public static class UriExtensionMethods
    {
        public static bool IsHttpScheme(this Uri uri)
        {
            if (uri != null)
            {
                if (uri.IsAbsoluteUri)
                {
                    return (uri.Scheme == Uri.UriSchemeHttp) || (uri.Scheme == Uri.UriSchemeHttps);
                }

            }
            return false;
        }
    }
}

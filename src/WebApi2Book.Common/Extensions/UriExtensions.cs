using System;

namespace WebApi2Book.Common.Extensions
{
    public static class UriExtensions
    {
        public static Uri GetBaseUri(this Uri originalUri)
        {
            var queryDelimiterIndex = originalUri.AbsolutePath.IndexOf("?", StringComparison.Ordinal);
            return queryDelimiterIndex < 0 ? 
                originalUri : new Uri(originalUri.AbsolutePath.Substring(0, queryDelimiterIndex));
        }

        public static string QueryWithoutLeadingQuestionMark(this Uri uri)
        {
            const int indexToSKipQueryDelimiter = 1;
            return uri.Query.Length > 1 ?
                uri.Query.Substring(indexToSKipQueryDelimiter) : string.Empty;
        }
    }
}

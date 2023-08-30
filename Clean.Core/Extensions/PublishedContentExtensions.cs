using System;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;
using Umbraco.Extensions;

namespace Clean.Core.Extensions
{
    public static class PublishedContentExtensions
    {
        public static string GetAltText(this IPublishedContent content, string altTextPropertyAlias = "altText")
        {
            if (content == null) return "";
            if (content.HasProperty(altTextPropertyAlias)) return content.Value<string>(altTextPropertyAlias);

            return "";
        }

        public static IPublishedContent GetAuthor(this IPublishedContent content, UmbracoHelper umbracoHelper, string authorPropertyAlias = "author")
        {
            if (content == null) return null;

            if (!content.HasProperty(authorPropertyAlias) || !content.HasValue(authorPropertyAlias)) return null;

            var authorId = content.Value<string>(authorPropertyAlias);
            var authorUdi = Udi.Create(new Uri(authorId));
            var author = umbracoHelper.Content(authorUdi);

            return author;
        }
    }
}

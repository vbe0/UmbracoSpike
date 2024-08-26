﻿using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoSpike.Extensions
{
    public static class PublishedContentExtensions
    {
        public static HomePage? GetHomePage(this IPublishedContent publishedContent)
        {
            return publishedContent.AncestorOrSelf<HomePage>();
        }

        public static SiteSetting? GetSiteSetting(this IPublishedContent publishedContent)
        {
            var homePage = GetHomePage(publishedContent);
            if (homePage == null)
            {
                return null;
            }
            return homePage?.FirstChild<SiteSetting>();
        }
    }
}

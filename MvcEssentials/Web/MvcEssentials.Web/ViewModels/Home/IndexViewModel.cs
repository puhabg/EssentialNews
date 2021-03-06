﻿namespace MvcEssentials.Web.ViewModels.Home
{
    using System.Collections.Generic;
    using Partials;

    public class IndexViewModel
    {
        public IEnumerable<NewsArticleIndexViewModel> Articles { get; set; }

        public IEnumerable<ArticleCarouselViewModel> TopNews { get; set; }
    }
}
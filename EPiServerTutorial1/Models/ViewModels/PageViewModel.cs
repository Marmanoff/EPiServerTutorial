using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace EPiServerTutorial1.Models.ViewModels
{
    public class PageViewModel<T>
    {
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; set; }
    }

    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T page) where T : PageData
        {
            return new PageViewModel<T>(page);
        }
    }
}
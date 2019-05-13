using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServerTutorial1.Controllers;

namespace EPiServerTutorial1.Models.Pages
{
    [ContentType(DisplayName = "EpicPage", GUID = "81039c09-0da1-4e30-9c3c-ba3dc845ab27", Description = "")]

    public class EpicPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}
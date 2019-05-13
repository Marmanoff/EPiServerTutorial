using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.UI.Report;

namespace EPiServerTutorial1.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "1295D4F3-71F9-476A-A807-D633DD142D6F", Description = "This is a StartPage")]
    [ImageUrl("~/Static/Img/picture.png")]
    [AvailableContentTypes(Availability.Specific,
        Include = new []{ typeof(EpicPage)},
        ExcludeOn = new []{ typeof(StartPage)}
        )]

    public class StartPage : PageData
    {
        [Display(
            Name = "Main Body",
            GroupName = SystemTabNames.Content,
            Description = "This is my main body description",
            Order = 1
        )]

        public virtual XhtmlString MainBody { get; set; }
    }
}
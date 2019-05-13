using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EPiServerTutorial1.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "5df26368-9f8c-4d3d-be03-08980035f9e9", Description = "")]
    public class StartPage : PageData
    {
        [Display(
            Name = "Main Body",
            GroupName = SystemTabNames.Content,
            Description = "This is my main body description",
            Order = 1
        )]

        //Defines if this property should have a different value for each language
        [CultureSpecific]

        //Do we want the property to be visible in editor mode? false = no, true = yes
        [ScaffoldColumn(true)]

        //The property value can be a maximum of 255 characters, and the property has to be a string
        [StringLength(255)]

        //If false, this property cannot be edited by editors, if true it can.
        [Editable(true)]

        //Editors need to fill in this property before publishing the project
        [Required]

        //We can now search the EPiServer browser, using the information within MainBody to find what we want
        [Searchable]
        public virtual String MainBody { get; set; }
    }
}
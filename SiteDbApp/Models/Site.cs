using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace SiteDbApp.Models
{
    public class Site
    {
        [Key]
        public int SiteID { get; set; }
        [Required]
        [EmailAddress]
        public string userName { get; set; }
        //[DataType(DataType.Url)]
        //[Required]
        //public Uri siteUrl { get; set; }
        [Required]
        public string siteUrl { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

    }
}
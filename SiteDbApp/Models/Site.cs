using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

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
      //  [Index("IX_Uri",IsUnique = true)]
    
        [Required]
        [DataType(DataType.Url)]
        public string siteUrl { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SiteDbApp.Models
{
    public class SiteInitializer :CreateDatabaseIfNotExists<SitesContext>
    {
        protected override void Seed(SitesContext context)
        {
            base.Seed(context);

            var sites = new List<Site>
            {
                new Site {
                    userName = "User1@asd.com",
                    //siteUrl = new Uri("https://www.google.com.ua/"),
                    siteUrl = "https://www.google.com.ua/",
                    Date = DateTime.Today.AddDays(-5),
                    Description = "It's a Google"
                },
                new Site {
                    userName = "User1@asd.com",
                    //siteUrl = new Uri("https://www.bing.com/"),
                    siteUrl ="https://www.bing.com/",
                    Date = DateTime.Today.AddDays(-15),
                    Description = "Bing"
                }

            };
            sites.ForEach(s => context.Sites.Add(s));
            context.SaveChanges();
            
        }
    }
}
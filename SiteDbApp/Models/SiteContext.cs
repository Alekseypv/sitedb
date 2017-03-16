using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SiteDbApp.Models
{
    public class SitesContext : DbContext //ISiteContext //for future mocks
    {
        public SitesContext() : base("SiteDB") { }

        public DbSet<Site> Sites { get; set; }

    }

    
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SiteDbApp.Models;

namespace SiteDbApp.Controllers
{
    public class SitesApiController : ApiController
    {
        private SitesContext db = new SitesContext();

        // GET: api/SitesApi
        public IQueryable<Site> GetSites()
        {
            return db.Sites;
        }

        // GET: api/SitesApi/5
        [ResponseType(typeof(Site))]
        public IHttpActionResult GetSite(int id)
        {
            Site site = db.Sites.Find(id);
            if (site == null)
            {
                return NotFound();
            }

            return Ok(site);
        }

        // PUT: api/SitesApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSite(int id, Site site)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != site.SiteID)
            {
                return BadRequest();
            }

            db.Entry(site).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SiteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/SitesApi
        [ResponseType(typeof(Site))]
        public IHttpActionResult PostSite(Site site)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sites.Add(site);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = site.SiteID }, site);
        }

        // DELETE: api/SitesApi/5
        [ResponseType(typeof(Site))]
        public IHttpActionResult DeleteSite(int id)
        {
            Site site = db.Sites.Find(id);
            if (site == null)
            {
                return NotFound();
            }

            db.Sites.Remove(site);
            db.SaveChanges();

            return Ok(site);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SiteExists(int id)
        {
            return db.Sites.Count(e => e.SiteID == id) > 0;
        }
    }
}
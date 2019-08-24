using Podcast_BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Podcast_BE.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PodcastsController : ApiController
    {
        private Podcast[] Podcasts = new Podcast[]
        {
            new Podcast { id = 1, _id = Guid.NewGuid(), Name = "Nerdificent", LastUpdate = new DateTime() },
            new Podcast { id = 2, _id = Guid.NewGuid(), Name = "Hello From The Magic Tavern", LastUpdate = new DateTime() },
            new Podcast { id = 3, _id = Guid.NewGuid(), Name = "EUphoria Podcast", LastUpdate = new DateTime() },
            new Podcast { id = 4, _id = Guid.NewGuid(), Name = "Swindled", LastUpdate = new DateTime() },
            new Podcast { id = 5, _id = Guid.NewGuid(), Name = "Abroad In Japan", LastUpdate = new DateTime() },
        };

        // GET: api/Podcasts
        public IEnumerable<Podcast> Get()
        {
            return this.Podcasts;
        }

        // GET: api/Podcasts/5
        public IHttpActionResult Get(int id)
        {
            Podcast podcast = this.Podcasts.FirstOrDefault((p) => p.id == id);

            if (podcast == null)
            {
                return NotFound();
            }

            return Ok(podcast);
        }
    }
}

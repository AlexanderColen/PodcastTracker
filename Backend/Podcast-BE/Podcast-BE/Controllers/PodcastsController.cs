using Podcast_BE.Models;
using Podcast_BE.Services;
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
        // TODO Find a way to autowire the service.
        private readonly PodcastsService podcastService = new PodcastsService();

        // GET: api/Podcasts
        public IHttpActionResult Get()
        {
            IEnumerable<Podcast> podcasts = this.podcastService.GetPodcasts();

            if (podcasts == null)
            {
                return NotFound();
            }

            return Ok(podcasts);
        }

        // GET: api/Podcasts/[UUID]
        public IHttpActionResult Get(Guid UUID)
        {
            Podcast podcast = this.podcastService.GetPodcast(UUID);

            if (podcast == null)
            {
                return NotFound();
            }

            return Ok(podcast);
        }

        // GET: api/podcasts/find
        public IHttpActionResult Find(String Name)
        {
            IEnumerable<Podcast> podcasts = this.podcastService.FindPodcasts(Name);

            if (podcasts == null)
            {
                return NotFound();
            }

            return Ok(podcasts);
        }
    }
}

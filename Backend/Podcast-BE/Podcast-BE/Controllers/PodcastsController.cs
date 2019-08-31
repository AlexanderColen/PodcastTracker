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
        public List<Podcast> Get()
        {
            return this.podcastService.Get();
        }

        // GET: api/Podcasts/[id]
        public Podcast Get(string id)
        {
            return this.podcastService.Get(id);
        }
    }
}

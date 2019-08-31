using Podcast_BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Podcast_BE.Services
{
    public class PodcastsService
    {
        public IEnumerable<Podcast> GetPodcasts()
        {
            // TODO Fetch all podcasts from database.
            throw new NotImplementedException();
        }

        public Podcast GetPodcast(Guid UUID)
        {
            // TODO Fetch podcast with UUID from database.
            throw new NotImplementedException();
        }

        public IEnumerable<Podcast> FindPodcasts(String Name)
        {
            // TODO Fetch podcasts containing Name from database.
            throw new NotImplementedException();
        }
    }
}
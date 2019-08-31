using MongoDB.Driver;
using Podcast_BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Podcast_BE.Services
{
    public class PodcastsService
    {
        private readonly IMongoCollection<Podcast> _podcasts;

        public PodcastsService()
        {
            var client = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            var db = client.GetDatabase("tracker");

            _podcasts = db.GetCollection<Podcast>("rss");
        }

        public List<Podcast> Get() =>
            _podcasts.Find(Podcast => true).ToList();

        public Podcast Get(string id) =>
            _podcasts.Find<Podcast>(Podcast => Podcast.Id == id).FirstOrDefault();

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
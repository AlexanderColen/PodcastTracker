using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Podcast_BE.Models
{
    public class TrackerDatabaseSettings : ITrackerDatabaseSettings
    {
        public string PodcastsCollectionName { get; set; }
        public string EpisodesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ITrackerDatabaseSettings
    {
        string PodcastsCollectionName { get; set; }
        string EpisodesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
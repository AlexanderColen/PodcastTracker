using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Podcast_BE.Models
{
    public class Podcast
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("rss")]
        public string RSS { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("lastRefresh")]
        public string LastUpdate { get; set; }
    }
}
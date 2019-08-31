using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Podcast_BE.Models
{
    public class Episode
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("uuid")]
        public string UUID { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("duration_raw")]
        public string DurationRaw { get; set; }

        [BsonElement("duration_formatted")]
        public string DurationFormatted { get; set; }

        [BsonElement("date")]
        public string Date { get; set; }

        [BsonElement("explicit")]
        public string Explicit { get; set; }

        [BsonElement("image")]
        public string Image { get; set; }
    }
}
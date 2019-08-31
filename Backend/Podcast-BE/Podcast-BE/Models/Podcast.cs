using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Podcast_BE.Models
{
    public class Podcast
    {
        public Guid _id { get; set; }
        public String RSS { get; set; }
        public String Name { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
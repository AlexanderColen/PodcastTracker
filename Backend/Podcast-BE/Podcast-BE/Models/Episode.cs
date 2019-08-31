using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Podcast_BE.Models
{
    public class Episode
    {
        public Guid UUID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public Int32 DurationRaw { get; set; }
        public String DurationFormatted { get; set; }
        public DateTime Date { get; set; }
        public Boolean Explicit { get; set; }
        public String Image { get; set; }
    }
}
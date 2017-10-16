using System;
using System.Collections.Generic;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject
{
    public class LikeDetailsBo
    {
        public string PostBy { get; set; }
        public string LikedBy { get; set; }
        public string LikedByPhoto { get; set; }
        public string LikedByUser { get; set; }
        public string LikedOn { get; set; }
        public string PostUrl { get; set; }
        public string Title { get; set; }
        public int TotalLike { get; set; }
        public string PostByEmail { get; set; }
        public string LikedByEmail { get; set; }
    }
}

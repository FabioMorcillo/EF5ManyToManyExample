using System;

namespace ConsoleApp16.Models
{
    public class PostTag
    {
        public PostTag()
        {
            LinkCreated = DateTime.Now;
        }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public string TagId { get; set; }
        public Tag Tag { get; set; }

        public DateTime LinkCreated { get; set; }
    }
}

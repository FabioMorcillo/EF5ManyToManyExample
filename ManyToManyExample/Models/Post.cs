using System.Collections.Generic;

namespace ConsoleApp16.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public List<Tag> Tags { get; set; } 
    }
}

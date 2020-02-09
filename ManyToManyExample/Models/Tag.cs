using System.Collections.Generic;

namespace ConsoleApp16.Models
{
    public class Tag
    {
        public string TagId { get; set; }
        public string Content { get; set; }

        public List<Post> Posts { get; set; }
    }
}

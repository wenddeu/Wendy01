using System.Collections.Generic;

namespace SampleBlazorWeb.Models
{
    public class Rootobject
    {
        public List<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public int postId { get; set; }

        public int id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string body { get; set; }
    }
}

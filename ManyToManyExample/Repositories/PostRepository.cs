using ManyToManyExample.Models;

namespace ManyToManyExample.Repositories
{
    public static class PostRepository
    {
        public static (Post post1, Post post2, Post post3) AddRange()
        {
            var post1 = new Post
            {
                Content = "Post 1",
                Title = "Title Post 1"
            };

            var post2 = new Post
            {
                Content = "Post 2",
                Title = "Title Post 2"
            };

            var post3 = new Post
            {
                Content = "Post 3",
                Title = "Title Post 3"
            };

            Repository.Context.Posts.Add(post1);
            Repository.Context.Posts.Add(post2);
            Repository.Context.Posts.Add(post3);

            return (post1, post2, post3);
        }
    }
}

using ManyToManyExample.Models;

namespace ManyToManyExample.Repositories
{
    public static class PostsTagsRepository
    {
        public static void Add(Post post, Tag tag)
        {
            var postTag = new PostTag
            {
                Post = post,
                Tag = tag
            };

            Repository.Context.PostsTags.Add(postTag);
        }
    }
}

using ManyToManyExample.Context;

namespace ManyToManyExample.Repositories
{
    public static class Repository
    {
        public static readonly EF5DbContext Context = new EF5DbContext();

        public static void Initialize()
        {
            RemoveAll();

            var (post1, post2, post3) = PostRepository.AddRange();

            var (tag1, tag2, tag3) = TagRepository.AddRange();

            PostsTagsRepository.Add(post1, tag1);

            PostsTagsRepository.Add(post2, tag2);
            PostsTagsRepository.Add(post3, tag2);

            PostsTagsRepository.Add(post1, tag3);
            PostsTagsRepository.Add(post2, tag3);
            PostsTagsRepository.Add(post3, tag3);

            Context.SaveChanges();
        }

        public static void RemoveAll()
        {
            Context.PostsTags.RemoveRange(Context.PostsTags);
            Context.Posts.RemoveRange(Context.Posts);
            Context.Tags.RemoveRange(Context.Tags);

            Context.SaveChanges();
        }
    }
}

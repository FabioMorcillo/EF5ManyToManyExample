using ManyToManyExample.Models;

namespace ManyToManyExample.Repositories
{
    public static class TagRepository
    {
        public static (Tag tag1, Tag tag2, Tag tag3) AddRange()
        {
            var tag1 = new Tag
            {
                TagId = "1",
                Content = "Tag 1"
            };

            var tag2 = new Tag
            {
                TagId = "2",
                Content = "Tag 2"
            };

            var tag3 = new Tag
            {
                TagId = "3",
                Content = "Tag 3"
            };

            Repository.Context.Tags.Add(tag1);
            Repository.Context.Tags.Add(tag2);
            Repository.Context.Tags.Add(tag3);

            return (tag1, tag2, tag3);
        }
    }
}

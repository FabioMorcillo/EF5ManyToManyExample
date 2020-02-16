using System.Linq;

using ManyToManyExample.Helpers;
using ManyToManyExample.Repositories;

namespace ManyToManyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository.Initialize();

            PrintHelper.Title("- Entity Framework Core 5 Many-To-Many example -");

            PrintPostsTagsByTagId("1");
            PrintPostsTagsByTagId("2");
            PrintPostsTagsByTagId("3");
        }

        static void PrintPostsTagsByTagId(string tagId)
        {
            var postsTags = Repository
                .Context
                .PostsTags
                .Where(pt => pt.TagId.Equals(tagId));

            PrintHelper.SubTitle($"TagId: {tagId}");

            foreach (var postTag in postsTags)
            {
                PrintHelper.Text($"PostId: {postTag.PostId}");
            }

            PrintHelper.BlankLine();
        }
    }
}
using System;
using System.Linq;

using ConsoleApp16.Context;
using ConsoleApp16.Models;

namespace ConsoleApp16
{
    class Program
    {
        private static readonly EF5DbContext _context = new EF5DbContext();

        static void Main(string[] args)
        {
            InitializeAllData();

            PrintTitle();

            PrintPostsTagsByTagId("1");
            PrintPostsTagsByTagId("2");
            PrintPostsTagsByTagId("3");
        }

        static void InitializeAllData()
        {
            RemoveAllData();

            var (post1, post2, post3) = AddPosts();

            var (tag1, tag2, tag3) = AddTags();

            AddPostTag(post1, tag1);

            AddPostTag(post2, tag2);
            AddPostTag(post3, tag2);

            AddPostTag(post1, tag3);
            AddPostTag(post2, tag3);
            AddPostTag(post3, tag3);

            _context.SaveChanges();
        }

        static void PrintTitle()
        {
            var title = "- Entity Framework Core 5 Many-To-Many example -";

            Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));
            Console.WriteLine(title);
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));

            Console.WriteLine();
        }

        static void PrintPostsTagsByTagId(string tagId)
        {
            var postsTags = _context.PostsTags.Where(pt => pt.TagId.Equals(tagId));

            Console.WriteLine($"--- TagId: {tagId} ---");

            foreach(var postTag in postsTags)
            {
                Console.WriteLine($"PostId: {postTag.PostId}");
            }

            Console.WriteLine();
        }

        static void RemoveAllData()
        {
            _context.PostsTags.RemoveRange(_context.PostsTags);
            _context.Posts.RemoveRange(_context.Posts);
            _context.Tags.RemoveRange(_context.Tags);

            _context.SaveChanges();
        }

        static (Post post1, Post post2, Post post3) AddPosts()
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

            _context.Posts.Add(post1);
            _context.Posts.Add(post2);
            _context.Posts.Add(post3);

            return (post1, post2, post3);
        }

        static (Tag tag1, Tag tag2, Tag tag3) AddTags()
        {
            var tag1 = new Tag
            {
                TagId = "1",
                Content = "Teste"
            };

            var tag2 = new Tag
            {
                TagId = "2",
                Content = "Teste 2"
            };

            var tag3 = new Tag
            {
                TagId = "3",
                Content = "Teste 3"
            };

            _context.Tags.Add(tag1);
            _context.Tags.Add(tag2);
            _context.Tags.Add(tag3);

            return (tag1, tag2, tag3);
        }

        static void AddPostTag(Post post, Tag tag)
        {
            var postTag = new PostTag
            {
                Post = post,
                Tag = tag
            };

            _context.PostsTags.Add(postTag);
        }

        
    }
}
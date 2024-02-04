using EntityFrameworkCore_Getting_Started;
using System;
using System.Linq;

using var db = new BloggingContext();
Console.WriteLine($"Database path: {db.DbPath}.");

// How to create
Console.WriteLine("Inserting a new blog");
db.Add(new Blog { Url = "https://enesgunumdogdu.com.tr" });
db.SaveChanges();

// How to read
Console.WriteLine("Querying for a blog");
var blog = db.Blogs.OrderBy(b => b.BlogId).First();

// How to update
Console.WriteLine("Updating the blog and adding a post");
blog.Url = "https://enesgunumdogdu.com.tr/contact";
blog.Posts.Add(
    new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
db.SaveChanges();

// How to delete
Console.WriteLine("Delete the blog");
db.Remove(blog);
db.SaveChanges();

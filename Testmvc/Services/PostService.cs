using System;
using System.Collections.Generic;
using System.Linq;
using Testmvc.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
namespace Testmvc.Services
{
    public class PostService
    {
        private readonly IMongoCollection<Post> _posts;
        public PostService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("PostsDatabase"));
            var database = client.GetDatabase("PostsDatabase");
            _posts = database.GetCollection<Post>("Posts");
        }

        public List<Post> Get()
            {
                return _posts.Find(Post => true).ToList();
            }

            public Post Get(string id)
            {
                return _posts.Find<Post>(Post => Post.Id == id).FirstOrDefault();
            }

            public Post Create(Post post)
            {
            _posts.InsertOne(post);
                return post;
            }

            public void Update(string id, Post bookIn)
            {
            _posts.ReplaceOne(book => book.Id == id, bookIn);
            }

            public void Remove(Post bookIn)
            {
            _posts.DeleteOne(book => book.Id == bookIn.Id);
            }

            public void Remove(string id)
            {
            _posts.DeleteOne(book => book.Id == id);
            }
        }
    }

using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Testmvc.Models
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("PostTitle")]
        public string PostTitle { get; set; }

        [BsonElement("PostSubTitle")]
        public string PostSubTitle { get; set; }

        [BsonElement("PostImageURL")]
        public string PostImageURL { get; set; }

        [BsonElement("PostContent")]
        public string PostContent { get; set; }

        [BsonElement("PostCreatedOn")]
        public DateTime PostCreatedOn { get; set; } = DateTime.Now;


    }
}
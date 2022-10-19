using System;

namespace IdentityAuth.Models
{
    public class Article
    {
            public int id { get; set; }
            public string title { get; set; }
            public string body { get; set; }
            public bool publish { get; set; }
            public string appUserId { get; set; }
            public DateTime createdDate { get; set; }
            public DateTime modifiedDate { get; set; }
    }
}

using System;

namespace MyWeb.Models
{
    public class Comments
    {
        public int id {get;set;}
        public string userId {get;set;}
        public string comment {get;set;}
        public DateTime created_at {get;set;}
        public int ArticleId {get;set;}
    }
}
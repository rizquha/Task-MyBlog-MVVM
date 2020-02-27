using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWeb.Models
{
    public class Articles
    {
        public int id {get;set;}
        public string title {get;set;}
        public string image {get;set;}
        public string detail {get;set;}
        public DateTime created_at {get;set;}
        public string UserId{get;set;}
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWeb.Models;

namespace MyWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Articles> article {get;set;}
        public DbSet<Roles> role {get;set;}
        public DbSet<Comments> comments {get;set;}
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

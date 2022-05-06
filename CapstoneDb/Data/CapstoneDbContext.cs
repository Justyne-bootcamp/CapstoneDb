using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using CapstoneDb.Models;

namespace CapstoneDb.Data
{
    public class CapstoneDbContext: DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumPhoto> AlbumPhotos { get; set; }

        public CapstoneDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=JLMBQG3;Database=PastebookDb;User Id=sa;Password=sqlmalambing");
            }
        }


    }
}

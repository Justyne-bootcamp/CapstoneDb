using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace CapstoneDb.Models
{
    public class Post
    {
        [Key]
        public Guid PostId { get; set; }
        public Guid UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }
        public string TextContent { get; set; }
        public string PostPhotoPath { get; set; }
        public DateTime TimeStamp { get; set; }

        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}

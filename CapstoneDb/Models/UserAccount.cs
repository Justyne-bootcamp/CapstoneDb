using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CapstoneDb.Models
{
    public class UserAccount
    {
        [Key]
        public Guid UserAccountId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        public char Gender { get; set; }
        public int MobileNumber { get; set; }
        public string AboutMe { get; set; }
        public string ProfilePhotoPath { get; set; }

        public ICollection<Friend>? Friends { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Like>? Likes { get; set; }
        public ICollection<Post>? Posts { get; set; }
        public ICollection<Album>? Albums { get; set; }
    }
}

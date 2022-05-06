using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CapstoneDb.Models
{
    public class Album
    {
        public Guid AlbumId { get; set; }
        public string AlbumName { get; set; }
        public Guid UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }
        public ICollection<AlbumPhoto> AlbumPhotos { get; set; }
    }
}

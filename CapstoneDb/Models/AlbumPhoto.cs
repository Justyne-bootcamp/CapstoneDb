using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CapstoneDb.Models
{
    public class AlbumPhoto
    {
        public Guid AlbumPhotoId { get; set; }
        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
        public string AlbumPhotoPath { get; set; }
    }
}

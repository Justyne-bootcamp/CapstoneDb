using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CapstoneDb.Models
{
    public class Like
    {
        [Key]
        public Guid LikeId { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }

        //userId of liker
        public Guid? UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }

    }
}

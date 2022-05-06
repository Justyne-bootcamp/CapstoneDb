using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CapstoneDb.Models
{
    public class Friend
    {
        [Key]
        public Guid FriendId { get; set; }
        public Guid OwnAccountId { get; set; }

        //user account id of friend
        public Guid UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }
    }
}


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserProfile.Models;

namespace UserProfile.Data
{
    public class UserProfileContext  : DbContext
    {

        public UserProfileContext(DbContextOptions<UserProfileContext> options)
: base(options)
        {

        }

        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<SocialDetails> SocialDetails{ get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UserProfile.Data;

namespace UserProfile.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UserProfileContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UserProfileContext>>()))
            {
                // Look for any movies.
                if (context.UserDetails.Any())
                {
                    return;   // DB has been seeded
                }

                context.UserDetails.AddRange(
                    new UserDetails
                    {
                        userName = "Tom",
                        email = "tom@gmail.com",
                        dob = DateTime.Parse("1989-2-12"),
                        
                    },

                    new UserDetails
                    {
                        userName = "Jerry",
                        email = "jerry@gmail.com",
                        dob = DateTime.Parse("1989-2-24"),
                    },

                    new UserDetails
                    {
                        userName = "Pickachu",
                        email = "pickachu@gmail.com",
                        dob = DateTime.Parse("1989-3-12"),
                    },

                    new UserDetails
                    {
                        userName = "Tweety",
                        email = "tweety@gmail.com",
                        dob = DateTime.Parse("1989-4-12"),
                    }
                );
                context.SaveChanges();
            }
        }

    }
}

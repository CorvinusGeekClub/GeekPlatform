using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GeekPlatform.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = serviceProvider.GetRequiredService<GeekDatabaseContext>())
            {
                context.Database.Migrate();

                if (context.Profile.Any())
                {
                    return;
                }
                context.Profile.Add(new Profile()
                {
                    Name = "Marcell Tóth",
                    PicFileName = "blah.jpg",
                    TeamMember = "Oktatási",
                    Email = "tothmarcell97@gmail.com",
                    MembershipStart = DateTime.Now
                });
                context.SaveChanges();
            }
        }
    }
}

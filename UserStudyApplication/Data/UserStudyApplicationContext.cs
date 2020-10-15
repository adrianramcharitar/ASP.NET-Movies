using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace UserStudyApplication.Data
{
    public class UserStudyApplicationContext : DbContext
    {
        public UserStudyApplicationContext (DbContextOptions<UserStudyApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}

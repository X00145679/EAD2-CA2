using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EAD2CA2;

namespace EAD2CA2.Data
{
    public class VideoGameContext : DbContext
    {
        public VideoGameContext (DbContextOptions<VideoGameContext> options)
            : base(options)
        {
        }

        public DbSet<EAD2CA2.VideoGameListing> VideoGameListing { get; set; }
    }
}

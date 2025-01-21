using Microsoft.EntityFrameworkCore;
using VideoGameApi.Models;

namespace VideoGameApi.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options): DbContext(options)
    {
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();
        public DbSet<VideoGameDetail> VideoGameDetails => Set<VideoGameDetail>();
    }
}


//packages
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

//
using PlayListService.Web.Models;



namespace PlayListService.Web.Data
{
    public class PlayListServiceContext : DbContext
    {
        public PlayListServiceContext(DbContextOptions<PlayListServiceContext> options)
               : base(options)
        {

        }
        public DbSet<PlayList> Playlists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<PlayList_Song> PlayList_Songs { get; set; }

       
    }
}

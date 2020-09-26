using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayListService.Web.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public List<PlayList_Song> PlayListSongs { get; } = new List<PlayList_Song>();

    }
}

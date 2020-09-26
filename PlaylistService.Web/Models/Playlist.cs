using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayListService.Web.Models
{
    public class PlayList
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<PlayList_Song> PlayListSongs {get; } = new List<PlayList_Song>();   


    }
}

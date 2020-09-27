using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayListService.Web.Dtos
{
    public class SongDto
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public ICollection<PlayListDto> Playlists;
    }
}

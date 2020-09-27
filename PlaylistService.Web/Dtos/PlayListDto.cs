using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayListService.Web.Dtos
{
    public class PlayListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SongDto> Songs;
    }
}

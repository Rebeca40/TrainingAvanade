using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Application.Albums
{
    public interface IAlbumService
    {
        AlbumDto Get(string id);
        void Create(AlbumDto album);
    }
}

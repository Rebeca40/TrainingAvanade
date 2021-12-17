using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;

namespace Training.Core.Repositories
{
    public interface IAlbumRepository
    {
        Album Get(Guid id);

        void Create(Album album);
    }
}

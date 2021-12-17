using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Application.Base;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.Application.Albums
{
    public class AlbumService : ServiceBase, IAlbumService
    {

        private readonly IAlbumService _albumRepository;


        public AlbumService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _albumRepository = (IAlbumService)unitOfWork.AlbumRepository;
        }
        public void Create(AlbumDto dto)
        {
            var album = dto;

            _albumRepository.Create(album);
            _unitOfWork.CommitTransaction();
        }

        public AlbumDto Get(string id)
        {
            return _albumRepository.Get(id);
        }
    }
}

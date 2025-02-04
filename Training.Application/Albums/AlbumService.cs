﻿using System;
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

        private readonly IAlbumRepository _albumRepository;


        public AlbumService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _albumRepository = unitOfWork.AlbumRepository;
        }
        public void Create(AlbumDto dto)
        {
            var album = Map(dto);

            _albumRepository.Create(album);
            _unitOfWork.CommitTransaction();
        }

        public AlbumDto Get(Guid id)
        {
            return MapEntity(_albumRepository.Get(id));
        }

        private Album Map(AlbumDto dto)
        {
            return new Album
            {
                Name = dto.Name,
                Author = dto.Author
            };
        }

        private AlbumDto MapEntity(Album dto)
        {
            return new AlbumDto
            {
                Name = dto.Name,
                Author = dto.Author
            };
        }
    }
}

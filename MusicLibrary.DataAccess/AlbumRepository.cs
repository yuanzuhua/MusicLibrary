﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary.Data;
using MusicLibrary.DataAccess.Interfaces;

namespace MusicLibrary.DataAccess
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly IDbConnection _database;

        public AlbumRepository(IDbConnection database)
        {
            _database = database;
        }

        public Album GetAlbumByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Album> FindAllAlbumsByGenre(Data.Genre genre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Data.Artist> FindAllAlbumsByArtist(Data.Artist artist)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Album> GetAllAlbums()
        {
            throw new NotImplementedException();
        }

        public void CreateAlbum(Album album)
        {
            throw new NotImplementedException();
        }
    }
}

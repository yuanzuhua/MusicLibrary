﻿using System.Collections.Generic;
using MusicLibrary.Data;

namespace MusicLibrary.DataAccess.Interfaces
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetAllGenres();

        Genre GetGenreByName(string genreName);

        void CreateGenre(Genre genre);
    }
}
﻿using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MusicLibrary.Data;
using MusicLibrary.DataAccess.Interfaces;

namespace MusicLibrary.DataAccess
{
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly IDbConnection _database;


        private readonly string _basePlaylistQuery = @"SELECT 
playlist.Id as Id, playlist.Name as PlaylistName
FROM dbo.Playlist playlist";

        private readonly string _baseTrackQuery = @"SELECT 
track.Name, track.TrackNumber, track.Length
FROM dbo.Track track INNER JOIN dbo.xrPlaylistTrack xr
ON xr.TrackId = track.Id";

        public PlaylistRepository(IDbConnection database)
        {
            _database = database;
        }

        public void CreatePlaylist(Playlist playlist)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Playlist> GetAllPlaylists()
        {
            var results = _database.Query(_basePlaylistQuery);

            return results.Select(res => new Playlist()
            {
                PlaylistName = res.PlaylistName,
                Tracks = GetTracksForPlaylist(res.Id)
            });
        }

        private IEnumerable<Track> GetTracksForPlaylist(int playlistId)
        {
            var sql = _baseTrackQuery + " WHERE xr.PlaylistId=@playlistId";

            return _database.Query<Track>(sql, new { playlistId = playlistId });
        }
    }
}
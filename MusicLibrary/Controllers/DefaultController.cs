﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using log4net;
using MusicLibrary.Data;
using MusicLibrary.Models;
using MusicLibrary.Services.Interfaces;

namespace MusicLibrary.Controllers
{
    public class DefaultController : Controller
    {
        private ILog _logger;
        private IAlbumService _albumService;
        private IPlaylistService _playlistService;

        public DefaultController(ILog logger, IAlbumService albumService, IPlaylistService playlistService)
        {
            _playlistService = playlistService;
            _albumService = albumService;
            _logger = logger;
        }

        // GET: Default
        public ActionResult Index()
        {
            var albums =Mapper.Map<IEnumerable<Album>,IEnumerable<ViewAllAlbumViewModel>>(_albumService.GetAllAlbums());

            return View(albums);
        }
    }
}
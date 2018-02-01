using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tech_Exercise.Models;
using static Tech_Exercise.Models.MusicLibraryModel;
using Tech_Exercise.Data;
using Microsoft.EntityFrameworkCore;

namespace Tech_Exercise.Controllers
{
    public class HomeController : Controller
    {
        private MusicLibraryContext dbc = new MusicLibraryContext();

        public IActionResult Index()
        {
            IEnumerable<Song> _viewModel;
            _viewModel = dbc.Song.AsEnumerable();
            return View(_viewModel);
        }

        public IActionResult Song()
        {

            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

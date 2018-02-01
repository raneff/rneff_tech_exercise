using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech_Exercise.Data;
using Microsoft.AspNetCore.Mvc;
using static Tech_Exercise.Models.MusicLibraryModel;

namespace Tech_Exercise.Controllers
{
    public class SongController : Controller
    {
        private MusicLibraryContext dbc = new MusicLibraryContext();


        [HttpPost]
        public IActionResult Add(string piece, string composer, DateTime dateCheckedOut, DateTime dueDate)
        {
            
            Song newSong = new Song
            {
                Piece = piece,
                Composer = composer,
                DateCheckedOut = dateCheckedOut,
                DueDate = dueDate,

            };
            dbc.Song.Add(newSong);
            dbc.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Add(){
            return View(); 
        }
    }
}

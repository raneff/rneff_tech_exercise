using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tech_Exercise.Models
{
    public class MusicLibraryModel
    {    
        public class Song{
        public string Piece { get; set; }
        public string Composer { get; set; }
            public DateTime DateCheckedOut { get; set; }
            public DateTime DueDate { get; set; }
            public int ID { get; set; }
        }
    }
}
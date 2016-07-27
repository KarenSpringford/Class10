using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Class10.Models
{
    public class Album
    {
        /// <summary>
        /// This is the empty constuctor
        /// </summary>
        /// 
        public Album()
        {

        }

        /// <summary>
        /// This constructor takes one parameter - Title
        /// </summary>
        /// 

            public Album (string Title)
        {
            this.Title = Title;
        }
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}
}
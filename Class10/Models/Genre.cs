using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Class10.Models
{
    public class Genre
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        /// 
        public Genre()
        {

        }

        /// <summary>
        /// This consturcotr takes one parameter - Name
        /// </summary>
        /// 
        public Genre (string Name)
        {
            this.Name = Name;
        }

            public int GenreId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public List<Album> Albums { get; set; }
        }
    }
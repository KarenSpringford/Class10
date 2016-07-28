﻿using System;
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

            public virtual int GenreId { get; set; }
            public virtual string Name { get; set; }
            public virtual string Description { get; set; }
            public virtual List<Album> Albums { get; set; }
        }
    }
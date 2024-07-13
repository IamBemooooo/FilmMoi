﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Genres
{
    public class GenreUpdateRequest
    {
        public Guid ID { get; set; }
        public string GenreName { get; set; }

        public Guid? ModifiedBy { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.DataTransferObj.Users.Utilities
{
    public class SeedMailRequest
    {
        public bool type {  get; set; } // true is activating account,false is send code
        public string email {get; set;}
    }
}

﻿using FilmMoi.Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.DataTransferObj.Films
{
    public class FilmDto
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public TimeSpan AvgDuration { get; set; }
        public int TotalEpisode { get; set; }
        public string Description { get; set; }
        public FilmStatus Status { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
    }
}

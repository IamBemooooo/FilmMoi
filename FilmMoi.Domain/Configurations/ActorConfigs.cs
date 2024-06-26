﻿using FilmMoi.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Models.Configurations
{
    public class ActorConfigs : IEntityTypeConfiguration<Actors>
    {
        public void Configure(EntityTypeBuilder<Actors> builder)
        {
            builder.HasKey(x => x.ID);
        }
    }
}

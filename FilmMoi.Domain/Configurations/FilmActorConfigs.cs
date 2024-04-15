using FilmMoi.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Models.Configurations
{
    public class FilmActorConfigs : IEntityTypeConfiguration<FilmActors>
    {
        public void Configure(EntityTypeBuilder<FilmActors> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Actor).WithMany(x => x.filmActors).HasForeignKey(x => x.ID_ACtor);
            builder.HasOne(x => x.Film).WithMany(x => x.filmActors).HasForeignKey(x => x.ID_Film);
        }
    }
}

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
    public class GenreFilmConfigs : IEntityTypeConfiguration<GenreFilms>
    {
        public void Configure(EntityTypeBuilder<GenreFilms> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Genre).WithMany(x => x.GenreFilms).HasForeignKey(x => x.ID_Genre);
            builder.HasOne(x => x.Film).WithMany(x => x.GenreFilms).HasForeignKey(x => x.ID_Film);
        }
    }
}

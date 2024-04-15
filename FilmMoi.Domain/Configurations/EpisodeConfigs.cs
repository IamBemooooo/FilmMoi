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
    public class EpisodeConfigs : IEntityTypeConfiguration<Episodes>
    {
        public void Configure(EntityTypeBuilder<Episodes> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Film).WithMany(x => x.Episodes).HasForeignKey(x => x.ID_Film);
        }
    }
}

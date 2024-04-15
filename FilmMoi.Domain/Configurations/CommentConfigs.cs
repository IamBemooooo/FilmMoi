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
    public class CommentConfigs : IEntityTypeConfiguration<Comments>
    {
        public void Configure(EntityTypeBuilder<Comments> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.User).WithMany(x => x.Comments).HasForeignKey(x => x.ID_User);
            builder.HasOne(x => x.Film).WithMany(x => x.Comments).HasForeignKey(x => x.ID_Film);
        }
    }
}

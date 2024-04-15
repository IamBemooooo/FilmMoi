using System;
using System.Collections.Generic;
using System.Reflection;
using FilmMoi.Models.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilmMoi.Domain.Models;

public partial class FlimMoiContext : DbContext
{
    public FlimMoiContext()
    {

    }

    public FlimMoiContext(DbContextOptions<FlimMoiContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer("Server=SURINRIN\\SQLEXPRESS01;Database=FlimMoi;Trusted_Connection=True;TrustServerCertificate=True");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    #region 
   
    #endregion

}

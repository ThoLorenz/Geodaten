using System;
using Geodaten.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace Geodaten.WebAPI.Data
    {
    public class Geodaten_Context : DbContext
        {

        public Geodaten_Context(DbContextOptions<Geodaten_Context> options)
        : base(options)
            {
            }

        public DbSet<OpenStreetMap> OpenStreetMap { get; set; }
        }

    }

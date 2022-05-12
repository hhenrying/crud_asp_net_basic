using System;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;

namespace CRUD.Datos
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options ):base(options)
        {

        }

        public DbSet<Cita> Citas { get; set; }
    }
}

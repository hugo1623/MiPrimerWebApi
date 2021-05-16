﻿using Microsoft.EntityFrameworkCore;
using MiPrimerWebApi.Entities;

namespace MiPrimerWebApi.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Autor> Autores { get; set; }
    }
}
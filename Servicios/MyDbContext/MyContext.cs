using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Reflection.Metadata;

namespace Servicios.MyDbContext
{
    public class MyContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }

        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<ExpedienteMedico> ExpedientesMedico { get; set; }
        public DbSet<Rol> Role { get; set; }
        public DbSet<UsuarioRol> UsuarioRol { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Clinica>()
            .HasMany(clinic => clinic.usiarios)
            .WithOne(usuarios => usuarios.clinica)
            .HasForeignKey(usuarios => usuarios.clinicaId);


            modelBuilder.Entity<Usuario>()
            .HasOne(usuario => usuario.expedienteMedico)
            .WithOne(expedienteMedico => expedienteMedico.usuario)
            .HasForeignKey<ExpedienteMedico>(expedienteMedico => expedienteMedico.usuarioId);


            modelBuilder.Entity<Usuario>()
            .HasMany(usuario => usuario.roles)
            .WithMany(roles => roles.usiarios)
            .UsingEntity<UsuarioRol>();

        }


    }


        }


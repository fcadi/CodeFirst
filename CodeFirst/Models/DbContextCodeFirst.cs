﻿using System.Data.Entity;
using CodeFirst.Models.ClassesExemplo;
using CodeFirst.Models.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CodeFirst.Models
{
    public class DbContextCodeFirst : DbContext
    {
        public DbContextCodeFirst()
            : base("ConexaoDbCodeFirst")
        {
            /* Inicializa o banco de dados com valores setados */
            Database.SetInitializer(new CodeFirstBdInicializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /* Alterar o dbo padrao */
            // modelBuilder.HasDefaultSchema("seguranca");
           
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
    }

    public class SegurancaDbContext : IdentityDbContext<ApplicationUser>
    {
        public SegurancaDbContext()
            : base("ConexaoSeguranca", throwIfV1Schema: false)
        {
            //Database.SetInitializer(new SegurancaInicializacao());
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static SegurancaDbContext Create()
        {
            return new SegurancaDbContext();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    /* Alterar o dbo padrao */
        //    modelBuilder.HasDefaultSchema("seguranca");
        //    modelBuilder.Entity<IdentityUser>().ToTable("tbl_usuarios").Property(p => p.Id).HasColumnName("UserId");
        //    modelBuilder.Entity<ApplicationUser>().ToTable("tbl_usuarios").Property(p => p.Id).HasColumnName("UserId");
        //    modelBuilder.Entity<IdentityUserRole>().ToTable("tbl_regrasUsuarios");
        //    modelBuilder.Entity<IdentityUserLogin>().ToTable("tbl_loginUsuarios");
        //    modelBuilder.Entity<IdentityUserClaim>().ToTable("tbl_userClaims");
        //    modelBuilder.Entity<IdentityRole>().ToTable("tbl_regrasGerais");
        //}

    }

}
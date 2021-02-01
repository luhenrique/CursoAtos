

using System.Collections.Generic;
using cadeMedicoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace cadeMedicoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        /*CRIANDO AS TABELAS*/
        public DbSet<MedicoModel> Medicos{get; set;}
        public DbSet<CidadeModel> Cidades{get; set;}
        public DbSet<EspecialidadeModel> Especialidades{get; set;}
        public DbSet<UsuarioModel> Usuarios{get; set;}
        public DbSet<PrivilegioModel> Privilegios{get; set;}

        protected override void OnModelCreating(ModelBuilder builder){

            builder.Entity<MedicoModel>()
                .HasData(new List<MedicoModel>(){
                    
            });
        }

    }


}


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
                    new MedicoModel(1, "Luiz", 2, "323440", "900999",1),
                    new MedicoModel(2, "Joao", 1, "434440", "912999",2),
                    new MedicoModel(3, "Clyetin", 3, "6464440", "932999",3),
                    new MedicoModel(4, "Jorgin", 5, "756440", "944999",4),
                    new MedicoModel(5, "Joana", 4, "756440", "953999",5)
            });

                        builder.Entity<CidadeModel>()
                .HasData(new List<CidadeModel>(){
                    new CidadeModel(1, "Apucarana", "PR"),
                    new CidadeModel(2, "Lodrina", "PR"),
                    new CidadeModel(3, "Maringa", "PR"),
                    new CidadeModel(4, "São Paulo", "SP"),
                    new CidadeModel(5, "Rio de Janeiro", "RJ")
            });

                        builder.Entity<EspecialidadeModel>()
                .HasData(new List<EspecialidadeModel>(){
                    new EspecialidadeModel(1, "Ortopedia"),
                    new EspecialidadeModel(2, "Podologia"),
                    new EspecialidadeModel(3, "Otorrinolaringologia"),
                    new EspecialidadeModel(4, "Pediatria"),
                    new EspecialidadeModel(5, "Geral"),

            });
                        builder.Entity<UsuarioModel>()
                .HasData(new List<UsuarioModel>(){
                    new UsuarioModel(1, "Luiz", "Suroki", "123", 1),
                    new UsuarioModel(2, "João", "Jao", "123", 2),
                    new UsuarioModel(3, "Joana", "jota", "123", 1),
                    new UsuarioModel(4, "Cloves", "Fonseca", "123", 1),
                    new UsuarioModel(5, "Marcelo", "Knwood", "123", 3),

            });
                        builder.Entity<PrivilegioModel>()
                .HasData(new List<PrivilegioModel>(){
                    new PrivilegioModel(1, "MASTER"),
                    new PrivilegioModel(2, "ADM"),
                    new PrivilegioModel(3, "USER"),

            });


            builder.Entity<MedicoCidade>()
                .HasKey(MC => new {MC.MedicoId, MC.CidadeId});

            builder.Entity<MedicoCidade>().HasData(new List<MedicoCidade>(){
                new MedicoCidade() {MedicoId = 1, CidadeId = 1},
                new MedicoCidade() {MedicoId = 2, CidadeId = 2},
                new MedicoCidade() {MedicoId = 3, CidadeId = 3},
                new MedicoCidade() {MedicoId = 4, CidadeId = 4},
                new MedicoCidade() {MedicoId = 5, CidadeId = 5},
            });
        }

    }


}
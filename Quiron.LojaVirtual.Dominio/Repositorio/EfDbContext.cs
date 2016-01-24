using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    //faz  mapeamento de baco
    public class EfDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }


        //remove a pluralização das tabelas automáticas do entity
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //indica que a classe produto é referente a tabbela Produtos
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }

    }
    
}
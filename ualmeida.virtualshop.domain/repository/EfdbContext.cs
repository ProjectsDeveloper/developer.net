using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ualmeida.virtualshop.domain.entity;

namespace ualmeida.virtualshop.domain.repository
{
    public class EfdbContext : DbContext
    {
        /*Mapeamento das Tabelas em Context Entity FrameWork
         * Todos DbSet's estarão Aqui
         */
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Retira Pluralização das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}

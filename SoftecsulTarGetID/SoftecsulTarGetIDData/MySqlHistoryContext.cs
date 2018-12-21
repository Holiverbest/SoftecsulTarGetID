using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftecsulTarGetID.SoftecsulTarGetIDData
{
    public class MySqlHistoryContext : HistoryContext
    {
        //Adicionamos ao projeto a classe MySqlHistoryContext.
        //Nesta classe podemos sobrescrever o metodo OnModelCreating onde iremos modificar o tamanho máximo da chave.
        public MySqlHistoryContext(DbConnection connection, string defaultSchema)
            : base(connection, defaultSchema)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(200).IsRequired();
        }
    }
}

using SoftecsulTarGetID.SoftecsulTarGetIDModel;
using System.Data.Entity;
using SoftecsulTarGetID.Migrations;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SoftecsulTarGetID.SoftecsulTarGetIDData
{
    class TarGetIDContext : DbContext
    {

        //public TarGetIDContext() : base("DesktopBaseMySql")
        public TarGetIDContext() : base("DesktopBase")
        {
            //E agora vamos modificar o construtor do contexto para ele chamar o DatabaseInitializer,
            //que é quem faz todo o processo acontecer:
            //https://msdn.microsoft.com/pt-br/library/jj856238.aspx
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TarGetIDContext, Configura>());



            Configuration.ValidateOnSaveEnabled = true;
            //início do código de criptografia
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var _cs = config.GetSection("connectionStrings") as ConnectionStringsSection;

            if (!_cs.SectionInformation.IsProtected)
            {
                _cs.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                config.Save();
            }

            _cs.SectionInformation.ForceSave = true;
            config.Save();

            var strc = Database.Connection;
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteEquipamento> ClienteEquipamentos { get; set; }
        public DbSet<TipoManutencao> TipoManutencoes { get; set; }
        public DbSet<StatusRegistro> StatusRegistros { get; set; }

    }
}

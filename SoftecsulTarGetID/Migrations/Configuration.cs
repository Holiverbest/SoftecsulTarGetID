namespace SoftecsulTarGetID.Migrations
{
    using SoftecsulTarGetID.SoftecsulTarGetIDModel;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MySql.Data.MySqlClient;
    using System.Data.Entity;

    internal sealed class Configura : DbMigrationsConfiguration<SoftecsulTarGetID.SoftecsulTarGetIDData.TarGetIDContext>
    {

        public Configura()
        {
            //Esta última opção fica a seu critério, pois se você não habilitar a opção e 
            //o Migrations não conseguir atualizar o banco de dados. você receberá um erro.
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SoftecsulTarGetID.SoftecsulTarGetIDData.TarGetIDContext";

            //Para iniciar uma migração para o Mysql
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());

           
            //HABILITA PARA TESTE E CARREGAR VALORES DEFAULT
            //SoftecsulTarGetIDData.TarGetIDContext cx = new SoftecsulTarGetIDData.TarGetIDContext();
            //Seed(cx);
        }

        protected override void Seed(SoftecsulTarGetID.SoftecsulTarGetIDData.TarGetIDContext context)
        {
            //  This method will be called after migrating to the latest version.
            ///https://docs.microsoft.com/pt-br/ef/ef6/modeling/code-first/migrations/index
            /////Execute o comando Enable-Migrations no Console do Gerenciador de Pacotes
            //Este comando adicionou uma pasta Migrations ao projeto. Essa nova pasta contém dois arquivos:

            if (!context.Clientes.Any() || !context.ClienteEquipamentos.Any() || !context.TipoManutencoes.Any())
            {
                TipoManutencao tp1 = new TipoManutencao("On-Line");
                TipoManutencao tp2 = new TipoManutencao("Mensalidade Presencial");
                TipoManutencao tp3 = new TipoManutencao("On-Line Com Atualização");
                TipoManutencao tp4 = new TipoManutencao("Mensalidade On-Line");
                TipoManutencao tp5 = new TipoManutencao("Presencial");
                TipoManutencao tp6 = new TipoManutencao("Por-Hora");

                context.TipoManutencoes.Add(tp1);
                context.TipoManutencoes.Add(tp2);
                context.TipoManutencoes.Add(tp3);
                context.TipoManutencoes.Add(tp4);
                context.TipoManutencoes.Add(tp5);
                context.TipoManutencoes.Add(tp6);

                Cliente c1 = new Cliente("Softecsul Tecnologia", "Softecsul Tecnologia Ltda", "73.922.916/0001-72", true, "8.13.5.2", true, true, tp1);
                Cliente c2 = new Cliente("Teste Tecnologia", "Teste Tecnologia Ltda", "73.922.916/0001-73", true, "8.14.0.0", true, true, tp2);
                Cliente c3 = new Cliente("Cliente Tecnologia", "Cliente Tecnologia Ltda", "73.922.916/0001-74", true, "8.13.4.0", true, true, tp3);
                Cliente c4 = new Cliente("Fornecedor Tecnologia", "Fornecedor Tecnologia Ltda", "73.922.916/0001-75", true, "8.13.4.7", true, true, tp4);
                Cliente c5 = new Cliente("Contato Tecnologia", "Contato Tecnologia Ltda", "73.922.916/0001-78", true, "8.13.5.1", true, true, tp5);
                Cliente c6 = new Cliente("Digito Tecnologia", "Digito Tecnologia Ltda", "73.922.916/0001-79", true, "8.13.5.0", true, true, tp6);

                context.Clientes.Add(c1);
                context.Clientes.Add(c2);
                context.Clientes.Add(c3);
                context.Clientes.Add(c4);
                context.Clientes.Add(c5);
                context.Clientes.Add(c6);

                ClienteEquipamento ce1 = new ClienteEquipamento("ECF EPSON TM-T81 FBIII", "ECF", "TM-T81 FBIII", "EPSON", "EP081100000000000001", "4900", c1);
                ClienteEquipamento ce2 = new ClienteEquipamento("ECF EPSON TM-T81 FBIII", "ECF", "TM-T81 FBIII", "EPSON", "EP081100000000000002", "4710", c2);
                ClienteEquipamento ce3 = new ClienteEquipamento("ECF BEMATECH MP4200FIII", "ECF", "MP4200FIII", "BEMATECH", "BE11EMULADOR00000000", "70445", c3);
                ClienteEquipamento ce4 = new ClienteEquipamento("ECF BEMATECH MP4200FIII", "ECF", "MP4200FIII", "BEMATECH", "BE111810101110035360", "70542", c3);
                ClienteEquipamento ce5 = new ClienteEquipamento("ECF BEMATECH MP4200FIII", "ECF", "MP4200FIII", "BEMATECH", "BE111810101110035361", "70542", c4);
                ClienteEquipamento ce6 = new ClienteEquipamento("ECF EPSON TM-T81 FBIII", "ECF", "TM-T81 FBIII", "EPSON", "EP081100000000000003", "4710", c4);
                ClienteEquipamento ce7 = new ClienteEquipamento("ECF URANO", "ECF", "URANO 01", "URANO", "URANO00000000000003", "4710", c5);
                ClienteEquipamento ce8 = new ClienteEquipamento("ECF BEMATECH MP4000FII", "ECF", "MP4000FII", "BEMATECH", "BE111810101110035360", "4710", c6);

                context.ClienteEquipamentos.Add(ce1);
                context.ClienteEquipamentos.Add(ce2);
                context.ClienteEquipamentos.Add(ce3);
                context.ClienteEquipamentos.Add(ce4);
                context.ClienteEquipamentos.Add(ce5);
                context.ClienteEquipamentos.Add(ce6);


                context.SaveChanges();
            }


            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

namespace SoftecsulTarGetID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialMigrationMySql : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteEquipamentoes",
                c => new
                {
                    ClienteEquipamentoId = c.Int(nullable: false, identity: true),
                    NomeEquipamento = c.String(unicode: false),
                    TipoEquipamento = c.String(unicode: false),
                    ModeloEquipamento = c.String(unicode: false),
                    FabricanteEquipamento = c.String(unicode: false),
                    VersaoEquipamento = c.String(unicode: false),
                    VersaoDll = c.String(unicode: false),
                    ClienteId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ClienteEquipamentoId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                //.Index(t => t.ClienteId, anonymousArguments: new { Type = "BTrees" });
               .Index(t => t.ClienteId);


            CreateTable(
                "dbo.Clientes",
                c => new
                {
                    ClienteId = c.Int(nullable: false, identity: true),
                    NomeFantasia = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    RazaoSocial = c.String(nullable: false, unicode: false),
                    CNPJ = c.String(nullable: false, unicode: false),
                    Inativo = c.Boolean(nullable: false),
                    Versao = c.String(unicode: false),
                    HabilitaAtualizacao = c.Boolean(nullable: false),
                    AtualizarOnLine = c.Boolean(nullable: false),
                    TipoManutencaoId = c.Int(nullable: false),
                    Limite = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.TipoManutencaos", t => t.TipoManutencaoId, cascadeDelete: true)
                  //.Index(t => t.TipoManutencaoId, anonymousArguments: new { Type = "BTrees" });
                  .Index(t => t.TipoManutencaoId);

            CreateTable(
                "dbo.TipoManutencaos",
                c => new
                {
                    TipoManutencaoId = c.Int(nullable: false, identity: true),
                    Tipo = c.String(unicode: false),
                })
                .PrimaryKey(t => t.TipoManutencaoId);

            CreateTable(
                "dbo.StatusRegistroes",
                c => new
                {
                    StatusRegistroId = c.Int(nullable: false, identity: true),
                    Tabela = c.String(unicode: false),
                    IDTabela = c.String(maxLength: 20, storeType: "nvarchar"),
                    Funcionario = c.String(unicode: false),
                })
                .PrimaryKey(t => t.StatusRegistroId, anonymousArguments: new { Type = "BTrees" });

        }

        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "TipoManutencaoId", "dbo.TipoManutencaos");
            DropForeignKey("dbo.ClienteEquipamentoes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Clientes", new[] { "TipoManutencaoId" });
            DropIndex("dbo.ClienteEquipamentoes", new[] { "ClienteId" });
            DropTable("dbo.StatusRegistroes");
            DropTable("dbo.TipoManutencaos");
            DropTable("dbo.Clientes");
            DropTable("dbo.ClienteEquipamentoes");
        }
    }
}

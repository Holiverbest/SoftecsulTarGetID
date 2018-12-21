namespace SoftecsulTarGetID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteEquipamentoes",
                c => new
                {
                    ClienteEquipamentoId = c.Int(nullable: false, identity: true),
                    NomeEquipamento = c.String(),
                    TipoEquipamento = c.String(),
                    ModeloEquipamento = c.String(),
                    VersaoEquipamento = c.String(),
                    VersaoDll = c.String(),
                    ClienteId = c.Int(nullable: false),
                    FabricanteEquipamento = c.String(),
                })
                .PrimaryKey(t => t.ClienteEquipamentoId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);

            CreateTable(
                "dbo.Clientes",
                c => new
                {
                    ClienteId = c.Int(nullable: false, identity: true),
                    NomeFantasia = c.String(),
                    RazaoSocial = c.String(),
                    CNPJ = c.String(),
                    Inativo = c.Boolean(nullable: false),
                    Versao = c.String(),
                    HabilitaAtualizacao = c.Boolean(nullable: false),
                    AtualizarOnLine = c.Boolean(nullable: false),
                    TipoManutencaoId = c.Int(nullable: false),
                    Limite = c.Decimal(),
                })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.TipoManutencaos", t => t.TipoManutencaoId, cascadeDelete: true)
                .Index(t => t.TipoManutencaoId);

            CreateTable(
                "dbo.TipoManutencaos",
                c => new
                {
                    TipoManutencaoId = c.Int(nullable: false, identity: true),
                    Tipo = c.String(),
                })
                .PrimaryKey(t => t.TipoManutencaoId);

            CreateTable(
             "dbo.StatusRegistroes",
             c => new
             {
                 StatusRegistroId = c.Int(nullable: false, identity: true),
                 Tabela = c.String(),
                 IDTabela = c.String(),
                 Funcionario = c.String()
             })
             .PrimaryKey(t => t.StatusRegistroId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "TipoManutencaoId", "dbo.TipoManutencaos");
            DropIndex("dbo.Clientes", new[] { "TipoManutencaoId" });

            DropForeignKey("dbo.ClienteEquipamentoes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Clientes", new[] { "ClienteId" });

            DropTable("dbo.TipoManutencaos");
            DropTable("dbo.Clientes");
            DropTable("dbo.ClienteEquipamentoes");

            DropIndex("dbo.StatusRegistroes", new[] { "StatusRegistroId" });
            DropTable("dbo.StatusRegistroes");
        }
    }
}

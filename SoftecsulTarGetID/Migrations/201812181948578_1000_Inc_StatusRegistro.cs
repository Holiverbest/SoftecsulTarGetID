namespace SoftecsulTarGetID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1000_Inc_StatusRegistro : DbMigration
    {
        public override void Up()
        {

            CreateTable(
               "dbo.StatusRegistroes",
               c => new
               {
                   StatusRegistroId = c.Int(nullable: false, identity: true),
                   Tabela = c.String(),
                   IDTabela= c.String (),
                   Funcionario=c.String ()
               })
               .PrimaryKey(t => t.StatusRegistroId);

        }
        
        public override void Down()
        {
            DropIndex("dbo.StatusRegistroes", new[] { "StatusRegistroId" });
            DropTable("dbo.StatusRegistroes");
        }
    }
}

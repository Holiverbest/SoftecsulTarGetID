namespace SoftecsulTarGetID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1000_Del_ClienteEquipamento_MeuNome : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ClienteEquipamentoes", "MeuNome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClienteEquipamentoes", "MeuNome", c => c.String());
        }
    }
}

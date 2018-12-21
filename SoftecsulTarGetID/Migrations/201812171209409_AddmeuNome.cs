namespace SoftecsulTarGetID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddmeuNome : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteEquipamentoes", "MeuNome", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteEquipamentoes", "MeuNome");
        }
    }
}

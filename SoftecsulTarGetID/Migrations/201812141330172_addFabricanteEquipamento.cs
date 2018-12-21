namespace SoftecsulTarGetID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFabricanteEquipamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteEquipamentoes", "FabricanteEquipamento", c => c.String());           
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteEquipamentoes", "FabricanteEquipamento");
        }
    }
}

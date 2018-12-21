namespace SoftecsulTarGetID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1000_Inc_CE_PortaComIDterminal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteEquipamentoes", "PortaCom", c => c.String());
            AddColumn("dbo.ClienteEquipamentoes", "IDterminal", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteEquipamentoes", "IDterminal");
            DropColumn("dbo.ClienteEquipamentoes", "PortaCom");
        }
    }
}

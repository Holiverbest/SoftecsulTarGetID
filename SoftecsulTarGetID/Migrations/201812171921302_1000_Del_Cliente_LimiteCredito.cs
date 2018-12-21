namespace SoftecsulTarGetID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1000_Del_Cliente_LimiteCredito : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clientes", "LimiteCredito");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "LimiteCredito", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}

namespace SoftecsulTarGetID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1000_Inc_Cliente_LimiteCredito : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "LimiteCredito", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            Sql("update clientes set LimiteCredito = 100");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "LimiteCredito");
        }
    }
}

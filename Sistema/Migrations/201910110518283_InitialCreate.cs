namespace Sistema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Double(nullable: false),
                        UltimaCompra = c.DateTime(nullable: false),
                        Estoque = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtoes");
        }
    }
}

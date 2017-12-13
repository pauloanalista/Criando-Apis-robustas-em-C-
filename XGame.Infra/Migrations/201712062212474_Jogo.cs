namespace XGame.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Jogo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 255, unicode: false),
                        Produtora = c.String(maxLength: 50, unicode: false),
                        Distribuidora = c.String(maxLength: 50, unicode: false),
                        Genero = c.String(maxLength: 50, unicode: false),
                        Site = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jogo");
        }
    }
}

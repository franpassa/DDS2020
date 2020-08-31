namespace Bibliotecas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracionInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(unicode: false),
                        FechaDeNacimiento = c.String(unicode: false),
                        Nacionalidad = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Libroes",
                c => new
                    {
                        Id_libro = c.Int(nullable: false, identity: true),
                        IDAutor = c.Int(nullable: false),
                        Categoria = c.String(unicode: false),
                        Editorial = c.String(unicode: false),
                        Nombre = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id_libro)
                .ForeignKey("dbo.Autors", t => t.IDAutor, cascadeDelete: true)
                .Index(t => t.IDAutor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Libroes", "IDAutor", "dbo.Autors");
            DropIndex("dbo.Libroes", new[] { "IDAutor" });
            DropTable("dbo.Libroes");
            DropTable("dbo.Autors");
        }
    }
}

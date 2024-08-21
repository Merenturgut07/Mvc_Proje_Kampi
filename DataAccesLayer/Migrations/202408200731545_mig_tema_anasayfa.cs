namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_tema_anasayfa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TemaAnaSayfas",
                c => new
                    {
                        TemaAnaSayfaId = c.Int(nullable: false, identity: true),
                        TemaAnaSayfaIsim = c.String(maxLength: 25),
                        TemaAnaSayfaAltBaslik = c.String(maxLength: 25),
                        TemaAnaSayfaBaslik = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.TemaAnaSayfaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TemaAnaSayfas");
        }
    }
}

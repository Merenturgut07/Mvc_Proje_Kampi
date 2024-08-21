namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_yetenekkartımekleme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.YetenekKartım",
                c => new
                    {
                        YKId = c.Int(nullable: false, identity: true),
                        YKTitle = c.String(maxLength: 25),
                        YKImageUrl = c.String(maxLength: 500),
                        YKDescription = c.String(maxLength: 100),
                        YKCinsiyet = c.String(maxLength: 5),
                        YKDogumTarihi = c.String(maxLength: 25),
                        YKAdres = c.String(maxLength: 50),
                        YKÜlke = c.String(maxLength: 50),
                        YKMail = c.String(maxLength: 50),
                        YKYetenekBaslik = c.String(maxLength: 15),
                        YKDeger = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.YKId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.YetenekKartım");
        }
    }
}

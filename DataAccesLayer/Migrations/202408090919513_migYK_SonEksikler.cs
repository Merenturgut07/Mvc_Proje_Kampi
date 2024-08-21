namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migYK_SonEksikler : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.YetenekKartım", "YKIsim", c => c.String(maxLength: 50));
            AddColumn("dbo.YetenekKartım", "YKYetenekBaslik4", c => c.String(maxLength: 25));
            AddColumn("dbo.YetenekKartım", "YKDeger1", c => c.String(maxLength: 50));
            AddColumn("dbo.YetenekKartım", "YKDeger2", c => c.String(maxLength: 50));
            AddColumn("dbo.YetenekKartım", "YKDeger3", c => c.String(maxLength: 50));
            AddColumn("dbo.YetenekKartım", "YKDeger4", c => c.String(maxLength: 50));
            DropColumn("dbo.YetenekKartım", "YKCinsiyet");
            DropColumn("dbo.YetenekKartım", "YKDogumTarihi");
            DropColumn("dbo.YetenekKartım", "YKAdres");
            DropColumn("dbo.YetenekKartım", "YKÜlke");
            DropColumn("dbo.YetenekKartım", "YKMail");
            DropColumn("dbo.YetenekKartım", "YKDeger");
        }
        
        public override void Down()
        {
            AddColumn("dbo.YetenekKartım", "YKDeger", c => c.String(maxLength: 50));
            AddColumn("dbo.YetenekKartım", "YKMail", c => c.String(maxLength: 50));
            AddColumn("dbo.YetenekKartım", "YKÜlke", c => c.String(maxLength: 50));
            AddColumn("dbo.YetenekKartım", "YKAdres", c => c.String(maxLength: 50));
            AddColumn("dbo.YetenekKartım", "YKDogumTarihi", c => c.String(maxLength: 25));
            AddColumn("dbo.YetenekKartım", "YKCinsiyet", c => c.String(maxLength: 5));
            DropColumn("dbo.YetenekKartım", "YKDeger4");
            DropColumn("dbo.YetenekKartım", "YKDeger3");
            DropColumn("dbo.YetenekKartım", "YKDeger2");
            DropColumn("dbo.YetenekKartım", "YKDeger1");
            DropColumn("dbo.YetenekKartım", "YKYetenekBaslik4");
            DropColumn("dbo.YetenekKartım", "YKIsim");
        }
    }
}

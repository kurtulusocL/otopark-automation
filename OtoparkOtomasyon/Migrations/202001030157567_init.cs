namespace OtoparkOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarBrands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 70),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarParkInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        PhoneNumber = c.String(),
                        Plaka = c.String(),
                        Year = c.String(),
                        Color = c.String(),
                        Description = c.String(),
                        CustomerId = c.Int(nullable: false),
                        CarBrandId = c.Int(nullable: false),
                        SerialId = c.Int(nullable: false),
                        CarParkId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarBrands", t => t.CarBrandId, cascadeDelete: true)
                .ForeignKey("dbo.CarParks", t => t.CarParkId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Serials", t => t.SerialId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.CarBrandId)
                .Index(t => t.SerialId)
                .Index(t => t.CarParkId);
            
            CreateTable(
                "dbo.CarParks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParkArea = c.String(),
                        State = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        PhoneNumber = c.String(),
                        Adress = c.String(),
                        EMail = c.String(),
                        Photo = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Serials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Seri = c.String(),
                        CarBrandId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarBrands", t => t.CarBrandId)
                .Index(t => t.CarBrandId);
            
            CreateTable(
                "dbo.Sells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        PhoneNumber = c.String(),
                        Plaka = c.String(),
                        Year = c.String(),
                        Color = c.String(),
                        TimePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Time = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        LeaveTime = c.DateTime(nullable: false),
                        CustomerId = c.Int(),
                        CarBrandId = c.Int(),
                        SerialId = c.Int(),
                        CarParkId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarBrands", t => t.CarBrandId)
                .ForeignKey("dbo.CarParks", t => t.CarParkId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Serials", t => t.SerialId)
                .Index(t => t.CustomerId)
                .Index(t => t.CarBrandId)
                .Index(t => t.SerialId)
                .Index(t => t.CarParkId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sells", "SerialId", "dbo.Serials");
            DropForeignKey("dbo.Sells", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Sells", "CarParkId", "dbo.CarParks");
            DropForeignKey("dbo.Sells", "CarBrandId", "dbo.CarBrands");
            DropForeignKey("dbo.CarParkInfoes", "SerialId", "dbo.Serials");
            DropForeignKey("dbo.Serials", "CarBrandId", "dbo.CarBrands");
            DropForeignKey("dbo.CarParkInfoes", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CarParkInfoes", "CarParkId", "dbo.CarParks");
            DropForeignKey("dbo.CarParkInfoes", "CarBrandId", "dbo.CarBrands");
            DropIndex("dbo.Sells", new[] { "CarParkId" });
            DropIndex("dbo.Sells", new[] { "SerialId" });
            DropIndex("dbo.Sells", new[] { "CarBrandId" });
            DropIndex("dbo.Sells", new[] { "CustomerId" });
            DropIndex("dbo.Serials", new[] { "CarBrandId" });
            DropIndex("dbo.CarParkInfoes", new[] { "CarParkId" });
            DropIndex("dbo.CarParkInfoes", new[] { "SerialId" });
            DropIndex("dbo.CarParkInfoes", new[] { "CarBrandId" });
            DropIndex("dbo.CarParkInfoes", new[] { "CustomerId" });
            DropTable("dbo.Sells");
            DropTable("dbo.Serials");
            DropTable("dbo.Customers");
            DropTable("dbo.CarParks");
            DropTable("dbo.CarParkInfoes");
            DropTable("dbo.CarBrands");
        }
    }
}

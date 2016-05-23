namespace MyABP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.USERS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        USER_STATUS = c.Int(),
                        LAST_LOGIN_TIME = c.DateTime(),
                        USER_GROUP_ID = c.Decimal(precision: 18, scale: 2),
                        USER_ID = c.String(),
                        USER_NM = c.Decimal(nullable: false, precision: 18, scale: 2),
                        USER_TYPE = c.Int(),
                        USER_NAME = c.String(),
                        USER_PWD = c.String(),
                        USER_PWD_QUT = c.String(),
                        USER_PWD_ANS = c.String(),
                        USER_BRI_DATE = c.DateTime(),
                        USER_SEX = c.Int(),
                        USER_TEL = c.String(),
                        USER_EMAIL = c.String(),
                        USER_INTRODUCE = c.String(),
                        USER_IP = c.String(),
                        USER_PROXY_IP = c.String(),
                        REMARK = c.String(),
                        USER_BUSINESS_NM = c.Decimal(precision: 18, scale: 2),
                        OTHER_ID = c.Decimal(precision: 18, scale: 2),
                        LOGIN_TIMES = c.Int(),
                        zz_sf = c.Int(),
                        zj = c.Int(),
                        user_worktime = c.DateTime(),
                        OTHER_ID_1 = c.String(),
                        OTHER_ID_2 = c.String(),
                        OTHER_ID_3 = c.String(),
                        OTHER_ID_4 = c.String(),
                        OTHER_ID_5 = c.String(),
                        xueli_id = c.Int(),
                        Degree_id = c.Int(),
                        id_card = c.String(),
                        MobileNo = c.String(),
                        UserNO = c.String(),
                        PhotoUrl = c.String(),
                        Title = c.Int(),
                        mingzu = c.String(),
                        fristxueli = c.Int(),
                        post_id = c.Int(),
                        Portal_Value_NBR = c.Int(),
                        CREATE_DATE = c.DateTime(),
                        Gold = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.USERS");
        }
    }
}

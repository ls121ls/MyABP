using System.Data.Entity.Migrations;

namespace MyABP.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MyABP.EntityFramework.MyABPDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyABP";
        }

        protected override void Seed(MyABP.EntityFramework.MyABPDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}

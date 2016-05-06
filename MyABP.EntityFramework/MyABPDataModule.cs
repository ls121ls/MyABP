using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using MyABP.EntityFramework;

namespace MyABP
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(MyABPCoreModule))]
    public class MyABPDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<MyABPDbContext>(null);
        }
    }
}

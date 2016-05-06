using System.Reflection;
using Abp.Modules;

namespace MyABP
{
    [DependsOn(typeof(MyABPCoreModule))]
    public class MyABPApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

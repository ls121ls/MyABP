using System.Reflection;
using Abp.Modules;

namespace MyABP
{
    public class MyABPCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

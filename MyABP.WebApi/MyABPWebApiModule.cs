using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace MyABP
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MyABPApplicationModule))]
    public class MyABPWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(MyABPApplicationModule).Assembly, "app")
                .Build();
        }
    }
}

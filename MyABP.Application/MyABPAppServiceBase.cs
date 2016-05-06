using Abp.Application.Services;

namespace MyABP
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyABPAppServiceBase : ApplicationService
    {
        protected MyABPAppServiceBase()
        {
            LocalizationSourceName = MyABPConsts.LocalizationSourceName;
        }
    }
}
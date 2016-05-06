using Abp.Web.Mvc.Controllers;

namespace MyABP.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class MyABPControllerBase : AbpController
    {
        protected MyABPControllerBase()
        {
            LocalizationSourceName = MyABPConsts.LocalizationSourceName;
        }
    }
}
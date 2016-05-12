using Abp.Web.Mvc.Controllers;
using MyABP.EntityFramework;

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
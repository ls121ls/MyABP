using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //模块表
        public class T_PortalModule:Entity
    {
    
          /// <summary>
        /// 主键标示
        /// </summary>
        public virtual int ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 模块名称
        /// </summary>
        public virtual string PM_ModuleName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 模块对应的页面
        /// </summary>
        public virtual string PM_ModuletoPage
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 控件属性
        /// </summary>
        public virtual string PM_ControlProperty
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string PM_ModuleRemark
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 所属类别
        /// </summary>
        public virtual int? MODULE_TYPE_ID
        {
            get; 
            set; 
        } 
         
           
                public T_PortalModule()
        {
        
        }
   
    }
    
}
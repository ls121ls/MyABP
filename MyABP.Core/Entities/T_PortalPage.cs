using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //页面表
        public class T_PortalPage:Entity
    {
    
          /// <summary>
        /// 主键标识列
        /// </summary>
        public virtual int ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 页面名称
        /// </summary>
        public virtual string PP_PageName_TXT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 重定向地址(1代表空值)
        /// </summary>
        public virtual string PP_PageURL_TXT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 平台ID
        /// </summary>
        public virtual int PP_PortalID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 扩展字段1
        /// </summary>
        public virtual string ExtendField1
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 扩展字段2
        /// </summary>
        public virtual string ExtendField2
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 扩展字段3
        /// </summary>
        public virtual string ExtendField3
        {
            get; 
            set; 
        } 
         
           
                public T_PortalPage()
        {
        
        }
   
    }
    
}
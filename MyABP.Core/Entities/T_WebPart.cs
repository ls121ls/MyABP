using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //页面配置表
        public class T_WebPart:Entity
    {
    
          /// <summary>
        /// ID
        /// </summary>
        public virtual int ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 布局配置
        /// </summary>
        public virtual string D_Behavior
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 所属平台
        /// </summary>
        public virtual int? D_PlatID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 所属页面
        /// </summary>
        public virtual int D_ModuleID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 模块配置
        /// </summary>
        public virtual string D_ShowModule
        {
            get; 
            set; 
        } 
         
           
                public T_WebPart()
        {
        
        }
   
    }
    
}
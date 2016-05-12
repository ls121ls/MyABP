using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //模块类别表
        public class T_PORTAL_MODULE_TYPE:Entity
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
        /// 类别名称
        /// </summary>
        public virtual string TYPE_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 父类别ID
        /// </summary>
        public virtual int? PARENT_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string REMARK
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 扩展字段1
        /// </summary>
        public virtual string OTHER_ID_1
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 扩展字段2
        /// </summary>
        public virtual string OTHER_ID_2
        {
            get; 
            set; 
        } 
         
           
                public T_PORTAL_MODULE_TYPE()
        {
        
        }
   
    }
    
}
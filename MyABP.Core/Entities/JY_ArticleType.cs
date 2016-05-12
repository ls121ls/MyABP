using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //文章频道表
        public class JY_ArticleType:Entity
    {
    
          /// <summary>
        /// 文章频道编号
        /// </summary>
        public virtual int ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 文章类型名称
        /// </summary>
        public virtual string TypeName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 父级编号
        /// </summary>
        public virtual int? parentid
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Portal_Value_NBR
        /// </summary>
        public virtual int? Portal_Value_NBR
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Status
        /// </summary>
        public virtual int? Status
        {
            get; 
            set; 
        } 
         
           
                public JY_ArticleType()
        {
        
        }
   
    }
    
}
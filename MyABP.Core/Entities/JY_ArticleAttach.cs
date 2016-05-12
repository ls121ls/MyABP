using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //文章附件表
        public class JY_ArticleAttach:Entity
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
        /// 课件编号
        /// </summary>
        public virtual int ArticleID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 附件地址
        /// </summary>
        public virtual string fujian
        {
            get; 
            set; 
        } 
         
           
                public JY_ArticleAttach()
        {
        
        }
   
    }
    
}
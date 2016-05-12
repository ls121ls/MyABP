using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //文章标识对应表
        public class JY_Article_Designator:Entity
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
        /// 文章ID
        /// </summary>
        public virtual int ArticleID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 标识ID
        /// </summary>
        public virtual int DesignatorID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 权重
        /// </summary>
        public virtual int weight
        {
            get; 
            set; 
        } 
         
           
                public JY_Article_Designator()
        {
        
        }
   
    }
    
}
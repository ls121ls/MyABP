using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //试卷分类表
        public class CHW_PAPER_TYPE:Entity
    {
    
          /// <summary>
        /// 分类ID
        /// </summary>
        public virtual int TYPE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 分类名
        /// </summary>
        public virtual string TYPE_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PARENT_ID
        /// </summary>
        public virtual int? PARENT_ID
        {
            get; 
            set; 
        } 
         
         
           
                public CHW_PAPER_TYPE()
        {
        
        }
   
    }
    
}
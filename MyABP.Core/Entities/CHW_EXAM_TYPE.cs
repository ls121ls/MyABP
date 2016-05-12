using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //考试分类表
        public class CHW_EXAM_TYPE:Entity
    {
    
          /// <summary>
        /// 自增长ID
        /// </summary>
        public virtual int TYPE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 分类名称
        /// </summary>
        public virtual string TYPE_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 父分类ID
        /// </summary>
        public virtual int? PARENT_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CHW_PAPER_TYPE
        /// </summary>
        public virtual int? CHW_PAPER_TYPE
        {
            get; 
            set; 
        } 
         
           
                public CHW_EXAM_TYPE()
        {
        
        }
   
    }
    
}
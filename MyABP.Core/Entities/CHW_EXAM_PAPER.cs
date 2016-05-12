using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //考试试卷对应表
        public class CHW_EXAM_PAPER:Entity
    {
    
          /// <summary>
        /// 自增长ID
        /// </summary>
        public virtual int EXAM_PAPER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 考试ID
        /// </summary>
        public virtual int? EXAM_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试卷ID
        /// </summary>
        public virtual int? PAPER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 排序
        /// </summary>
        public virtual int? EXAM_ITEM_ORDER
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
         
           
                public CHW_EXAM_PAPER()
        {
        
        }
   
    }
    
}
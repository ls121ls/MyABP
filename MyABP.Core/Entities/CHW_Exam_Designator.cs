using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //考试标识对应表
        public class CHW_Exam_Designator:Entity
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
        /// 考试ID
        /// </summary>
        public virtual int ExamID
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
         
           
                public CHW_Exam_Designator()
        {
        
        }
   
    }
    
}
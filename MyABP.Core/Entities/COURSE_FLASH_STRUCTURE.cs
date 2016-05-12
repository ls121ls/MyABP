using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC节点表
        public class COURSE_FLASH_STRUCTURE:Entity
    {
    
          /// <summary>
        /// 课程整数编号
        /// </summary>
        public virtual int course_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AICC节点编号
        /// </summary>
        public virtual string lesson_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// course_chapter
        /// </summary>
        public virtual int? course_chapter
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// course_node
        /// </summary>
        public virtual int? course_node
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// course_progress
        /// </summary>
        public virtual int? course_progress
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AICC节点标题
        /// </summary>
        public virtual string lesson_name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AICC课程公司编号
        /// </summary>
        public virtual string course_number
        {
            get; 
            set; 
        } 
         
           
                public COURSE_FLASH_STRUCTURE()
        {
        
        }
   
    }
    
}
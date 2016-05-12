using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //课程标识对应表
        public class Course_Designator:Entity
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
        /// 课程ID
        /// </summary>
        public virtual int CourseID
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
         
           
                public Course_Designator()
        {
        
        }
   
    }
    
}
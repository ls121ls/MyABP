using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //T_TrainClassCourse
        public class T_TrainClassCourse:Entity
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
        /// CourseID
        /// </summary>
        public virtual int? CourseID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 0 必修 1 选修
        /// </summary>
        public virtual int? CourseType
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TrainID
        /// </summary>
        public virtual int? TrainID
        {
            get; 
            set; 
        } 
         
           
                public T_TrainClassCourse()
        {
        
        }
   
    }
    
}
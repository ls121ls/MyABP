using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //COURSE_USER_STUDY
        public class COURSE_USER_STUDY:Entity
    {
    
          /// <summary>
        /// user_nm
        /// </summary>
        public virtual string user_nm
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// course_id
        /// </summary>
        public virtual string course_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// lesson_id
        /// </summary>
        public virtual string lesson_id
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
         
           
                public COURSE_USER_STUDY()
        {
        
        }
   
    }
    
}
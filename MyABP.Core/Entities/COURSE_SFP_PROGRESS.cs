using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //COURSE_SFP_PROGRESS
        public class COURSE_SFP_PROGRESS:Entity
    {
    
          /// <summary>
        /// course_id
        /// </summary>
        public virtual int? course_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// user_nm
        /// </summary>
        public virtual int? user_nm
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// progress
        /// </summary>
        public virtual int? progress
        {
            get; 
            set; 
        } 
         
           
                public COURSE_SFP_PROGRESS()
        {
        
        }
   
    }
    
}
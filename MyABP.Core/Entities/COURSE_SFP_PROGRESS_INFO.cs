using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //COURSE_SFP_PROGRESS_INFO
        public class COURSE_SFP_PROGRESS_INFO:Entity
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
        /// page
        /// </summary>
        public virtual string page
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
         
           
                public COURSE_SFP_PROGRESS_INFO()
        {
        
        }
   
    }
    
}
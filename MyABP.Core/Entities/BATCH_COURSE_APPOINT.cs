using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //BATCH_COURSE_APPOINT
        public class BATCH_COURSE_APPOINT:Entity
    {
    
          /// <summary>
        /// CourseId
        /// </summary>
        public virtual int CourseId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// BatchId
        /// </summary>
        public virtual decimal BatchId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// type
        /// </summary>
        public virtual int? type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CreateTime
        /// </summary>
        public virtual DateTime? CreateTime
        {
            get; 
            set; 
        } 
         
           
                public BATCH_COURSE_APPOINT()
        {
        
        }
   
    }
    
}
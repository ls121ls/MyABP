using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //COURSE_CLICK_RANK
        public class COURSE_CLICK_RANK:Entity
    {
    
          /// <summary>
        /// Course_id
        /// </summary>
        public virtual int Course_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// course_number
        /// </summary>
        public virtual string course_number
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// course_name
        /// </summary>
        public virtual string course_name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// course_createdate
        /// </summary>
        public virtual DateTime? course_createdate
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// click_number
        /// </summary>
        public virtual int? click_number
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Portal_value_nbr
        /// </summary>
        public virtual int Portal_value_nbr
        {
            get; 
            set; 
        } 
         
           
                public COURSE_CLICK_RANK()
        {
        
        }
   
    }
    
}
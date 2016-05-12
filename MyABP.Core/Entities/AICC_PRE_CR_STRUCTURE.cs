using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_PRE_CR_STRUCTURE
        public class AICC_PRE_CR_STRUCTURE:Entity
    {
    
          /// <summary>
        /// PRE_CR_STRUCTURE_NUM
        /// </summary>
        public virtual decimal PRE_CR_STRUCTURE_NUM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// COURSE_ID
        /// </summary>
        public virtual string COURSE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SYSTEM_ID
        /// </summary>
        public virtual string SYSTEM_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PRE_CHILD
        /// </summary>
        public virtual string PRE_CHILD
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CR_CHILD
        /// </summary>
        public virtual string CR_CHILD
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CR_RESULT
        /// </summary>
        public virtual string CR_RESULT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CR_NEXT
        /// </summary>
        public virtual string CR_NEXT
        {
            get; 
            set; 
        } 
         
           
                public AICC_PRE_CR_STRUCTURE()
        {
        
        }
   
    }
    
}
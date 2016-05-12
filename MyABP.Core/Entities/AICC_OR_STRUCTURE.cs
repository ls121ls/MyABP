using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_OR_STRUCTURE
        public class AICC_OR_STRUCTURE:Entity
    {
    
          /// <summary>
        /// OR_STRUCTURE_NUM
        /// </summary>
        public virtual decimal OR_STRUCTURE_NUM
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
        /// OR_CHILD
        /// </summary>
        public virtual string OR_CHILD
        {
            get; 
            set; 
        } 
         
           
                public AICC_OR_STRUCTURE()
        {
        
        }
   
    }
    
}
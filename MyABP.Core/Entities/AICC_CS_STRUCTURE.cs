using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_CS_STRUCTURE
        public class AICC_CS_STRUCTURE:Entity
    {
    
          /// <summary>
        /// CS_STRUCTURE_NUM
        /// </summary>
        public virtual decimal CS_STRUCTURE_NUM
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
        /// CS_CHILD
        /// </summary>
        public virtual string CS_CHILD
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CS_CHILD_ORDER
        /// </summary>
        public virtual decimal? CS_CHILD_ORDER
        {
            get; 
            set; 
        } 
         
           
                public AICC_CS_STRUCTURE()
        {
        
        }
   
    }
    
}
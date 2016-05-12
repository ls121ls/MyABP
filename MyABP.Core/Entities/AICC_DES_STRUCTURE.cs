using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_DES_STRUCTURE
        public class AICC_DES_STRUCTURE:Entity
    {
    
          /// <summary>
        /// DES_STRUCTURE_NUM
        /// </summary>
        public virtual decimal DES_STRUCTURE_NUM
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
        /// DEVELOPER_ID
        /// </summary>
        public virtual string DEVELOPER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TITLE
        /// </summary>
        public virtual string TITLE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// DESCRIPTION
        /// </summary>
        public virtual string DESCRIPTION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PARENT_SYSTEM_ID
        /// </summary>
        public virtual string PARENT_SYSTEM_ID
        {
            get; 
            set; 
        } 
         
           
                public AICC_DES_STRUCTURE()
        {
        
        }
   
    }
    
}
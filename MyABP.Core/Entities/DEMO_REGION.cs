using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //DEMO_REGION
        public class DEMO_REGION:Entity
    {
    
          /// <summary>
        /// REGION_ID
        /// </summary>
        public virtual decimal? REGION_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// REGION_CODE
        /// </summary>
        public virtual string REGION_CODE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// REGION_NAME
        /// </summary>
        public virtual string REGION_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PARENT_ID
        /// </summary>
        public virtual decimal? PARENT_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// REGION_LEVEL
        /// </summary>
        public virtual decimal? REGION_LEVEL
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// REGION_ORDER
        /// </summary>
        public virtual decimal? REGION_ORDER
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// REGION_NAME_EN
        /// </summary>
        public virtual string REGION_NAME_EN
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// REGION_SHORTNAME_EN
        /// </summary>
        public virtual string REGION_SHORTNAME_EN
        {
            get; 
            set; 
        } 
         
           
                public DEMO_REGION()
        {
        
        }
   
    }
    
}
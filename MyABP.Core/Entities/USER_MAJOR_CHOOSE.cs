using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //USER_MAJOR_CHOOSE
        public class USER_MAJOR_CHOOSE:Entity
    {
    
          /// <summary>
        /// STATUS_ID
        /// </summary>
        public virtual decimal? STATUS_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PAY_MONEY
        /// </summary>
        public virtual decimal? PAY_MONEY
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// USER_CHOOSE
        /// </summary>
        public virtual decimal? USER_CHOOSE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// USER_NM
        /// </summary>
        public virtual decimal USER_NM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// MAJOR_ID
        /// </summary>
        public virtual decimal MAJOR_ID
        {
            get; 
            set; 
        } 
         
           
                public USER_MAJOR_CHOOSE()
        {
        
        }
   
    }
    
}
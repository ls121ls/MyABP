using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //USER_TITLE
        public class USER_TITLE:Entity
    {
    
          /// <summary>
        /// USER_TITLE_NM
        /// </summary>
        public virtual int USER_TITLE_NM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// USER_TITLE_NAME
        /// </summary>
        public virtual string USER_TITLE_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PER_USER_TITLE_NM
        /// </summary>
        public virtual int? PER_USER_TITLE_NM
        {
            get; 
            set; 
        } 
         
           
                public USER_TITLE()
        {
        
        }
   
    }
    
}
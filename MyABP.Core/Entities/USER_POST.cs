using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //USER_POST
        public class USER_POST:Entity
    {
    
          /// <summary>
        /// Post_id
        /// </summary>
        public virtual int Post_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Post_name
        /// </summary>
        public virtual string Post_name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// per_post_id
        /// </summary>
        public virtual int? per_post_id
        {
            get; 
            set; 
        } 
         
           
                public USER_POST()
        {
        
        }
   
    }
    
}
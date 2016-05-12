using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //JY_CommentType
        public class JY_CommentType:Entity
    {
    
          /// <summary>
        /// C_id
        /// </summary>
        public virtual int C_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// C_typeName
        /// </summary>
        public virtual string C_typeName
        {
            get; 
            set; 
        } 
         
           
                public JY_CommentType()
        {
        
        }
   
    }
    
}
using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_RoleApplication
        public class sys_RoleApplication:Entity
    {
    
          /// <summary>
        /// A_RoleID
        /// </summary>
        public virtual int A_RoleID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// A_ApplicationID
        /// </summary>
        public virtual int A_ApplicationID
        {
            get; 
            set; 
        } 
         
           
                public sys_RoleApplication()
        {
        
        }
   
    }
    
}
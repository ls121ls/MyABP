using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_Applications
        public class sys_Applications:Entity
    {
    
          /// <summary>
        /// ApplicationID
        /// </summary>
        public virtual int ApplicationID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// A_AppName
        /// </summary>
        public virtual string A_AppName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// A_AppDescription
        /// </summary>
        public virtual string A_AppDescription
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// A_AppUrl
        /// </summary>
        public virtual string A_AppUrl
        {
            get; 
            set; 
        } 
         
           
                public sys_Applications()
        {
        
        }
   
    }
    
}
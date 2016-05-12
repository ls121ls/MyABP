using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_SystemInfo
        public class sys_SystemInfo:Entity
    {
    
          /// <summary>
        /// SystemID
        /// </summary>
        public virtual int SystemID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// S_Name
        /// </summary>
        public virtual string S_Name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// S_Version
        /// </summary>
        public virtual string S_Version
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// S_SystemConfigData
        /// </summary>
        public virtual byte[] S_SystemConfigData
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// S_Licensed
        /// </summary>
        public virtual string S_Licensed
        {
            get; 
            set; 
        } 
         
           
                public sys_SystemInfo()
        {
        
        }
   
    }
    
}
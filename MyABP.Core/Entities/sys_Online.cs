using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_Online
        public class sys_Online:Entity
    {
    
          /// <summary>
        /// OnlineID
        /// </summary>
        public virtual int OnlineID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// O_SessionID
        /// </summary>
        public virtual string O_SessionID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// O_UserName
        /// </summary>
        public virtual string O_UserName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// O_Ip
        /// </summary>
        public virtual string O_Ip
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// O_LoginTime
        /// </summary>
        public virtual DateTime O_LoginTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// O_LastTime
        /// </summary>
        public virtual DateTime O_LastTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// O_LastUrl
        /// </summary>
        public virtual string O_LastUrl
        {
            get; 
            set; 
        } 
         
           
                public sys_Online()
        {
        
        }
   
    }
    
}
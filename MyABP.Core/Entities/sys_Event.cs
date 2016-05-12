using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_Event
        public class sys_Event:Entity
    {
    
          /// <summary>
        /// EventID
        /// </summary>
        public virtual int EventID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// E_U_LoginName
        /// </summary>
        public virtual string E_U_LoginName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// E_UserID
        /// </summary>
        public virtual int? E_UserID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// E_DateTime
        /// </summary>
        public virtual DateTime E_DateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// E_ApplicationID
        /// </summary>
        public virtual int? E_ApplicationID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// E_A_AppName
        /// </summary>
        public virtual string E_A_AppName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// E_M_Name
        /// </summary>
        public virtual string E_M_Name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// E_M_PageCode
        /// </summary>
        public virtual string E_M_PageCode
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// E_From
        /// </summary>
        public virtual string E_From
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// E_Type
        /// </summary>
        public virtual int E_Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// E_IP
        /// </summary>
        public virtual string E_IP
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// E_Record
        /// </summary>
        public virtual string E_Record
        {
            get; 
            set; 
        } 
         
           
                public sys_Event()
        {
        
        }
   
    }
    
}
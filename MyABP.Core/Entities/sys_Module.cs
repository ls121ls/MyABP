using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_Module
        public class sys_Module:Entity
    {
    
          /// <summary>
        /// ModuleID
        /// </summary>
        public virtual int ModuleID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// M_ApplicationID
        /// </summary>
        public virtual int M_ApplicationID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// M_ParentID
        /// </summary>
        public virtual int M_ParentID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// M_PageCode
        /// </summary>
        public virtual string M_PageCode
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// M_CName
        /// </summary>
        public virtual string M_CName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// M_Directory
        /// </summary>
        public virtual string M_Directory
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// M_OrderLevel
        /// </summary>
        public virtual string M_OrderLevel
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// M_IsSystem
        /// </summary>
        public virtual int? M_IsSystem
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// M_Close
        /// </summary>
        public virtual int? M_Close
        {
            get; 
            set; 
        } 
         
           
                public sys_Module()
        {
        
        }
   
    }
    
}
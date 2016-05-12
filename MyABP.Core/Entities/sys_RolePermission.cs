using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_RolePermission
        public class sys_RolePermission:Entity
    {
    
          /// <summary>
        /// PermissionID
        /// </summary>
        public virtual int PermissionID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// P_RoleID
        /// </summary>
        public virtual int P_RoleID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// P_ApplicationID
        /// </summary>
        public virtual int P_ApplicationID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// P_PageCode
        /// </summary>
        public virtual string P_PageCode
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// P_Value
        /// </summary>
        public virtual int? P_Value
        {
            get; 
            set; 
        } 
         
           
                public sys_RolePermission()
        {
        
        }
   
    }
    
}
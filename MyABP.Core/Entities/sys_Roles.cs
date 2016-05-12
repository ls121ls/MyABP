using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //角色表
        public class sys_Roles:Entity
    {
    
          /// <summary>
        /// 角色ID
        /// </summary>
        public virtual int RoleID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 角色名称
        /// </summary>
        public virtual string R_RoleName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// R_Description
        /// </summary>
        public virtual string R_Description
        {
            get; 
            set; 
        } 
         
           
                public sys_Roles()
        {
        
        }
   
    }
    
}
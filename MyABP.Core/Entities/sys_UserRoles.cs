using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_UserRoles
        public class sys_UserRoles:Entity
    {
    
          /// <summary>
        /// 用户编号(user_NM)
        /// </summary>
        public virtual int R_UserID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 角色ID
        /// </summary>
        public virtual int R_RoleID
        {
            get; 
            set; 
        } 
         
           
                public sys_UserRoles()
        {
        
        }
   
    }
    
}
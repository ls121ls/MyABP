using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //不参加前台排行表
        public class USER_NOTTOPGROUP:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual decimal not_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户组编号
        /// </summary>
        public virtual decimal group_id
        {
            get; 
            set; 
        } 
         
           
                public USER_NOTTOPGROUP()
        {
        
        }
   
    }
    
}
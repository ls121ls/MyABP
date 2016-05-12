using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //民族表
        public class USER_NATION:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual int USER_NATION_nm
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 民族名称
        /// </summary>
        public virtual string user_NATION_name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// per_user_NATION_nm
        /// </summary>
        public virtual int? per_user_NATION_nm
        {
            get; 
            set; 
        } 
         
           
                public USER_NATION()
        {
        
        }
   
    }
    
}
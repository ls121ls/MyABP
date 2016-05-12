using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //职级表
        public class USER_LEVEL:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual int user_zj_nm
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 职级名称
        /// </summary>
        public virtual string user_zj_name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// per_user_zj_nm
        /// </summary>
        public virtual int? per_user_zj_nm
        {
            get; 
            set; 
        } 
         
           
                public USER_LEVEL()
        {
        
        }
   
    }
    
}
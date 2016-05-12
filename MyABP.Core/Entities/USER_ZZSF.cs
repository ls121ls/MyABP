using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //政治身份表
        public class USER_ZZSF:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual int user_zzsf_nm
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 政治身份名称
        /// </summary>
        public virtual string user_zzsf_name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// per_user_zzsf_nm
        /// </summary>
        public virtual int? per_user_zzsf_nm
        {
            get; 
            set; 
        } 
         
           
                public USER_ZZSF()
        {
        
        }
   
    }
    
}
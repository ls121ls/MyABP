using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //用户职务表
        public class USER_BUSINESS_MAIN:Entity
    {
    
          /// <summary>
        /// 职务编号
        /// </summary>
        public virtual decimal USER_BUSINESS_NM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 职务名称
        /// </summary>
        public virtual string USER_BUSINESS_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PER_USER_BUSINESS_NM
        /// </summary>
        public virtual decimal PER_USER_BUSINESS_NM
        {
            get; 
            set; 
        } 
         
           
                public USER_BUSINESS_MAIN()
        {
        
        }
   
    }
    
}
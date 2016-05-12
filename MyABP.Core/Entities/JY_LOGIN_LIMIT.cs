using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //登录限制表
        public class JY_LOGIN_LIMIT:Entity
    {
    
          /// <summary>
        /// SYS_ID
        /// </summary>
        public virtual decimal SYS_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SYS_NAME
        /// </summary>
        public virtual string SYS_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SYS_VALUE
        /// </summary>
        public virtual string SYS_VALUE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SYS_TYPE
        /// </summary>
        public virtual decimal? SYS_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ALLADM_ID
        /// </summary>
        public virtual decimal? ALLADM_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SYS_DESCRIPTION
        /// </summary>
        public virtual string SYS_DESCRIPTION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// VAL_1_DESCRIPTION
        /// </summary>
        public virtual string VAL_1_DESCRIPTION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// VAL_2_DESCRIPTION
        /// </summary>
        public virtual string VAL_2_DESCRIPTION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// VAL_3_DESCRIPTION
        /// </summary>
        public virtual string VAL_3_DESCRIPTION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// DISPLAY_TYPE
        /// </summary>
        public virtual string DISPLAY_TYPE
        {
            get; 
            set; 
        } 
         
           
                public JY_LOGIN_LIMIT()
        {
        
        }
   
    }
    
}
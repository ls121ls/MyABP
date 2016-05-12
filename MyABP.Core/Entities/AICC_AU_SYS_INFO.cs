using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_AU_SYS_INFO
        public class AICC_AU_SYS_INFO:Entity
    {
    
          /// <summary>
        /// AU_SYS_NUM
        /// </summary>
        public virtual decimal AU_SYS_NUM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// COURSE_ID
        /// </summary>
        public virtual string COURSE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AU_SYSTEM_ID
        /// </summary>
        public virtual string AU_SYSTEM_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AU_TYPE
        /// </summary>
        public virtual string AU_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// COMMAND_LINE
        /// </summary>
        public virtual string COMMAND_LINE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// FILE_NAME
        /// </summary>
        public virtual string FILE_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// WEB_LAUNCH
        /// </summary>
        public virtual string WEB_LAUNCH
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// MAX_SCORE
        /// </summary>
        public virtual decimal? MAX_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// MASTERY_SCORE
        /// </summary>
        public virtual decimal? MASTERY_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// MAX_TIME_ALLOWED
        /// </summary>
        public virtual string MAX_TIME_ALLOWED
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TIME_LIMIT_ACTION
        /// </summary>
        public virtual string TIME_LIMIT_ACTION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SYSTEM_VENDOR
        /// </summary>
        public virtual string SYSTEM_VENDOR
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CORE_VENDOR
        /// </summary>
        public virtual string CORE_VENDOR
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AU_PASSWD
        /// </summary>
        public virtual string AU_PASSWD
        {
            get; 
            set; 
        } 
         
           
                public AICC_AU_SYS_INFO()
        {
        
        }
   
    }
    
}
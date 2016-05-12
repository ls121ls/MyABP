using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_COMMENTS_STATUS
        public class AICC_COMMENTS_STATUS:Entity
    {
    
          /// <summary>
        /// COMMENTS_STATUS_NUM
        /// </summary>
        public virtual decimal COMMENTS_STATUS_NUM
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
        /// STUDENT_ID
        /// </summary>
        public virtual string STUDENT_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LESSON_ID
        /// </summary>
        public virtual string LESSON_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// COMMENTS_DATE
        /// </summary>
        public virtual DateTime COMMENTS_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// COMMENTS_TIME
        /// </summary>
        public virtual DateTime COMMENTS_TIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// COMMENTS_LOCATION
        /// </summary>
        public virtual string COMMENTS_LOCATION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// COMMENTS_COMMENT
        /// </summary>
        public virtual string COMMENTS_COMMENT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SESSION_ID
        /// </summary>
        public virtual string SESSION_ID
        {
            get; 
            set; 
        } 
         
           
                public AICC_COMMENTS_STATUS()
        {
        
        }
   
    }
    
}
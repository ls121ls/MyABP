using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_SCORE_STATUS
        public class AICC_SCORE_STATUS:Entity
    {
    
          /// <summary>
        /// SCORE_STATUS_NUM
        /// </summary>
        public virtual decimal SCORE_STATUS_NUM
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
        /// TRY_SCORE_TIME
        /// </summary>
        public virtual string TRY_SCORE_TIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TRY_SCORE
        /// </summary>
        public virtual string TRY_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TRY_STATUS
        /// </summary>
        public virtual string TRY_STATUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SCORE_DATE
        /// </summary>
        public virtual DateTime SCORE_DATE
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
         
           
                public AICC_SCORE_STATUS()
        {
        
        }
   
    }
    
}
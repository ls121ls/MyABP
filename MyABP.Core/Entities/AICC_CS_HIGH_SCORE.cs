using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_CS_HIGH_SCORE
        public class AICC_CS_HIGH_SCORE:Entity
    {
    
          /// <summary>
        /// CS_HIGH_SCORE_NUM
        /// </summary>
        public virtual decimal CS_HIGH_SCORE_NUM
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
        /// CS_HIGH_SCORE
        /// </summary>
        public virtual string CS_HIGH_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CS_HIGH_STATUS
        /// </summary>
        public virtual string CS_HIGH_STATUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CS_FIRST_DATE
        /// </summary>
        public virtual DateTime CS_FIRST_DATE
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
         
           
        /// <summary>
        /// BROWSE_SCORE
        /// </summary>
        public virtual decimal? BROWSE_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// BROWSE_COMPLETED_DATE_STR
        /// </summary>
        public virtual string BROWSE_COMPLETED_DATE_STR
        {
            get; 
            set; 
        } 
         
           
                public AICC_CS_HIGH_SCORE()
        {
        
        }
   
    }
    
}
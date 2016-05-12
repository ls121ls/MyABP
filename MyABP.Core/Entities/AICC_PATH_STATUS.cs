using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_PATH_STATUS
        public class AICC_PATH_STATUS:Entity
    {
    
          /// <summary>
        /// PATH_STATUS_NUM
        /// </summary>
        public virtual decimal PATH_STATUS_NUM
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
        /// PATH_DATE
        /// </summary>
        public virtual DateTime PATH_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PATH_TIME
        /// </summary>
        public virtual DateTime PATH_TIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PATH_LOCATION
        /// </summary>
        public virtual string PATH_LOCATION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PATH_STATUS
        /// </summary>
        public virtual string PATH_STATUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PATH_WHY_LEFT
        /// </summary>
        public virtual string PATH_WHY_LEFT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PATH_TIME_IN
        /// </summary>
        public virtual string PATH_TIME_IN
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
         
           
                public AICC_PATH_STATUS()
        {
        
        }
   
    }
    
}
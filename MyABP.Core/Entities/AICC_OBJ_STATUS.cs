using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_OBJ_STATUS
        public class AICC_OBJ_STATUS:Entity
    {
    
          /// <summary>
        /// OBJ_STATUS_NUM
        /// </summary>
        public virtual decimal OBJ_STATUS_NUM
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
        /// OBJ_DATE
        /// </summary>
        public virtual DateTime OBJ_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OBJ_TIME
        /// </summary>
        public virtual DateTime OBJ_TIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OBJ_OBJECTIVE_ID
        /// </summary>
        public virtual string OBJ_OBJECTIVE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OBJ_SCORE
        /// </summary>
        public virtual string OBJ_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OBJ_STATUS
        /// </summary>
        public virtual string OBJ_STATUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OBJ_MASTERY_TIME
        /// </summary>
        public virtual string OBJ_MASTERY_TIME
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
         
           
                public AICC_OBJ_STATUS()
        {
        
        }
   
    }
    
}
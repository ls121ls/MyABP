using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_INT_STATUS
        public class AICC_INT_STATUS:Entity
    {
    
          /// <summary>
        /// INT_STATUS_NUM
        /// </summary>
        public virtual decimal INT_STATUS_NUM
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
        /// INT_INTERACTION_ID
        /// </summary>
        public virtual string INT_INTERACTION_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// INT_DATE
        /// </summary>
        public virtual string INT_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// INT_TIME
        /// </summary>
        public virtual string INT_TIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// INT_OBJECTIVE_ID
        /// </summary>
        public virtual string INT_OBJECTIVE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// INT_TYPE
        /// </summary>
        public virtual string INT_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// INT_CORRECT_RESPONSE
        /// </summary>
        public virtual string INT_CORRECT_RESPONSE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// INT_RESPONSE_VALUE
        /// </summary>
        public virtual string INT_RESPONSE_VALUE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// INT_STUDENT_RESPONSE
        /// </summary>
        public virtual string INT_STUDENT_RESPONSE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// INT_RESULT
        /// </summary>
        public virtual string INT_RESULT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// INT_WEIGHTING
        /// </summary>
        public virtual string INT_WEIGHTING
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// INT_LATENCY
        /// </summary>
        public virtual string INT_LATENCY
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
         
           
                public AICC_INT_STATUS()
        {
        
        }
   
    }
    
}
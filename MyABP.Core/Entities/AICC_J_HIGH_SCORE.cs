using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_J_HIGH_SCORE
        public class AICC_J_HIGH_SCORE:Entity
    {
    
          /// <summary>
        /// J_HIGH_SCORE_NUM
        /// </summary>
        public virtual decimal J_HIGH_SCORE_NUM
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
        /// OBJ_OBJECTIVE_ID
        /// </summary>
        public virtual string OBJ_OBJECTIVE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OBJ_HIGH_SCORE
        /// </summary>
        public virtual string OBJ_HIGH_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OBJ_HIGH_STATUS
        /// </summary>
        public virtual string OBJ_HIGH_STATUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OBJ_FIRST_DATE
        /// </summary>
        public virtual DateTime? OBJ_FIRST_DATE
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
        /// uidcount
        /// </summary>
        public virtual int? uidcount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// timems
        /// </summary>
        public virtual int? timems
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// length
        /// </summary>
        public virtual int? length
        {
            get; 
            set; 
        } 
         
           
                public AICC_J_HIGH_SCORE()
        {
        
        }
   
    }
    
}
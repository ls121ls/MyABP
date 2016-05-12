using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_WINDOW_PREF
        public class AICC_WINDOW_PREF:Entity
    {
    
          /// <summary>
        /// WINDOW_PREF_NUM
        /// </summary>
        public virtual decimal WINDOW_PREF_NUM
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
        /// COURSE_ID
        /// </summary>
        public virtual string COURSE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// WINDOW_X
        /// </summary>
        public virtual string WINDOW_X
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OPERDATE
        /// </summary>
        public virtual DateTime OPERDATE
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
         
           
                public AICC_WINDOW_PREF()
        {
        
        }
   
    }
    
}
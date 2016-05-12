using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC_CS_SYS_INFO
        public class AICC_CS_SYS_INFO:Entity
    {
    
          /// <summary>
        /// CS_SYS_NUM
        /// </summary>
        public virtual decimal CS_SYS_NUM
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
        /// COURSE_CREATOR
        /// </summary>
        public virtual string COURSE_CREATOR
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// COURSE_SYSTEM
        /// </summary>
        public virtual string COURSE_SYSTEM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// COURSE_TITLE
        /// </summary>
        public virtual string COURSE_TITLE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AICCLEVEL
        /// </summary>
        public virtual string AICCLEVEL
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// MAX_FIELDS_CST
        /// </summary>
        public virtual decimal? MAX_FIELDS_CST
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// MAX_FIELDS_ORT
        /// </summary>
        public virtual decimal? MAX_FIELDS_ORT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TOTAL_AUS
        /// </summary>
        public virtual decimal? TOTAL_AUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TOTAL_BLOCKS
        /// </summary>
        public virtual decimal? TOTAL_BLOCKS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TOTAL_COMPLEX_OBJ
        /// </summary>
        public virtual decimal? TOTAL_COMPLEX_OBJ
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TOTAL_OBJECTIVES
        /// </summary>
        public virtual decimal? TOTAL_OBJECTIVES
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// VERSION
        /// </summary>
        public virtual string VERSION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// MAX_NORMAL
        /// </summary>
        public virtual decimal? MAX_NORMAL
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// COURSE_DESCRIPTION
        /// </summary>
        public virtual string COURSE_DESCRIPTION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// DURATION
        /// </summary>
        public virtual string DURATION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OPERDATE
        /// </summary>
        public virtual DateTime? OPERDATE
        {
            get; 
            set; 
        } 
         
           
                public AICC_CS_SYS_INFO()
        {
        
        }
   
    }
    
}
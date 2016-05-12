using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //TC_CourseList
        public class TC_CourseList:Entity
    {
    
          /// <summary>
        /// ID
        /// </summary>
        public virtual int ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TCID
        /// </summary>
        public virtual int? TCID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsCompulsory
        /// </summary>
        public virtual bool IsCompulsory
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CourseName
        /// </summary>
        public virtual string CourseName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Duration
        /// </summary>
        public virtual decimal? Duration
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TeacherName
        /// </summary>
        public virtual string TeacherName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CourseID
        /// </summary>
        public virtual int? CourseID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CreditHour
        /// </summary>
        public virtual decimal? CreditHour
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Remark
        /// </summary>
        public virtual string Remark
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TeacherRemark
        /// </summary>
        public virtual string TeacherRemark
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CourseRemark
        /// </summary>
        public virtual string CourseRemark
        {
            get; 
            set; 
        } 
         
           
                public TC_CourseList()
        {
        
        }
   
    }
    
}
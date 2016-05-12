using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //JY_CourseLog
        public class JY_CourseLog:Entity
    {
    
          /// <summary>
        /// id
        /// </summary>
        public virtual int id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UserID
        /// </summary>
        public virtual string UserID
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
        /// Data
        /// </summary>
        public virtual string Data
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CreateTime
        /// </summary>
        public virtual DateTime? CreateTime
        {
            get; 
            set; 
        } 
         
           
                public JY_CourseLog()
        {
        
        }
   
    }
    
}
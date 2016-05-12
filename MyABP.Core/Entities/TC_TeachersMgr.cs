using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //TC_TeachersMgr
        public class TC_TeachersMgr:Entity
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
        /// CreateTime
        /// </summary>
        public virtual DateTime? CreateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UpdateTime
        /// </summary>
        public virtual DateTime? UpdateTime
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
        /// Synopsis
        /// </summary>
        public virtual string Synopsis
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TeacherType
        /// </summary>
        public virtual string TeacherType
        {
            get; 
            set; 
        } 
         
           
                public TC_TeachersMgr()
        {
        
        }
   
    }
    
}
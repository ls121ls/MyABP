using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //JY_Teacher
        public class JY_Teacher:Entity
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
        /// TeacherName
        /// </summary>
        public virtual string TeacherName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TeacherTitle
        /// </summary>
        public virtual string TeacherTitle
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TeacherUnit
        /// </summary>
        public virtual string TeacherUnit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TeacherIntroduce
        /// </summary>
        public virtual string TeacherIntroduce
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TeacherPhoto
        /// </summary>
        public virtual string TeacherPhoto
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// url
        /// </summary>
        public virtual string url
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
         
           
                public JY_Teacher()
        {
        
        }
   
    }
    
}
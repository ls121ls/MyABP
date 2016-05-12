using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //班级教师表
        public class TearcherClass:Entity
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
        /// 班级ID
        /// </summary>
        public virtual int? ClassID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 学员ID
        /// </summary>
        public virtual int? TearcherID
        {
            get; 
            set; 
        } 
         
           
                public TearcherClass()
        {
        
        }
   
    }
    
}
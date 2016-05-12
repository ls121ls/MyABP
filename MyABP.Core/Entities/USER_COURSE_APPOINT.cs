using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //用户指定课程表
        public class USER_COURSE_APPOINT:Entity
    {
    
          /// <summary>
        /// 课程编号
        /// </summary>
        public virtual int CourseId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户编号
        /// </summary>
        public virtual decimal UserNm
        {
            get; 
            set; 
        } 
         
           
                public USER_COURSE_APPOINT()
        {
        
        }
   
    }
    
}
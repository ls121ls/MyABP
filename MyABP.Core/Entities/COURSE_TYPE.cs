using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //课件表现类型表
        public class COURSE_TYPE:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual int COURSE_TYPE_nm
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课件类型名称
        /// </summary>
        public virtual string COURSE_TYPE_name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// per_COURSE_TYPE_nm
        /// </summary>
        public virtual int? per_COURSE_TYPE_nm
        {
            get; 
            set; 
        } 
         
           
                public COURSE_TYPE()
        {
        
        }
   
    }
    
}
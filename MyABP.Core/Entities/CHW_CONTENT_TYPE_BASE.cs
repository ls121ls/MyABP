using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //试题库分类表
        public class CHW_CONTENT_TYPE_BASE:Entity
    {
    
          /// <summary>
        /// 自增长ID
        /// </summary>
        public virtual int TYPE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 分类名称
        /// </summary>
        public virtual string TYPE_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 父分类ID
        /// </summary>
        public virtual int? PARENT_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CHW_PAPER_TYPE
        /// </summary>
        public virtual int? CHW_PAPER_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课程ID(和Courseware表Course_id关联)
        /// </summary>
        public virtual int? course_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Status
        /// </summary>
        public virtual int? Status
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AddUser
        /// </summary>
        public virtual string AddUser
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AddTime
        /// </summary>
        public virtual DateTime? AddTime
        {
            get; 
            set; 
        } 
         
           
                public CHW_CONTENT_TYPE_BASE()
        {
        
        }
   
    }
    
}
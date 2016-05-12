using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //考试指定用户表
        public class CHW_EXAM_USER:Entity
    {
    
          /// <summary>
        /// 考试ID
        /// </summary>
        public virtual int exam_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户编号
        /// </summary>
        public virtual int user_nm
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// map_value
        /// </summary>
        public virtual int? map_value
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// chw_paper_type
        /// </summary>
        public virtual int? chw_paper_type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户名
        /// </summary>
        public virtual string user_id
        {
            get; 
            set; 
        } 
         
           
                public CHW_EXAM_USER()
        {
        
        }
   
    }
    
}
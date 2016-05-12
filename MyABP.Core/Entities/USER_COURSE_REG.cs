using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //用户选课表
        public class USER_COURSE_REG:Entity
    {
    
          /// <summary>
        /// 用户编号
        /// </summary>
        public virtual decimal USER_NM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课程编号
        /// </summary>
        public virtual decimal COURSE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 选课日期
        /// </summary>
        public virtual DateTime REG_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// REMARK
        /// </summary>
        public virtual string REMARK
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ASSIGN_ID
        /// </summary>
        public virtual decimal ASSIGN_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课程开始日期
        /// </summary>
        public virtual DateTime? START_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 最后一次学习日期
        /// </summary>
        public virtual DateTime active_date
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 学习次数
        /// </summary>
        public virtual int? active_time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 学分
        /// </summary>
        public virtual decimal? credit_hour
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 额外学分
        /// </summary>
        public virtual decimal? extra_credit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 进度
        /// </summary>
        public virtual decimal browse_score
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LAST_LOCATION
        /// </summary>
        public virtual string LAST_LOCATION
        {
            get; 
            set; 
        } 
         
           
                public USER_COURSE_REG()
        {
        
        }
   
    }
    
}
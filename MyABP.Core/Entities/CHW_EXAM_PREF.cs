using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //考试记录表
        public class CHW_EXAM_PREF:Entity
    {
    
          /// <summary>
        /// 自增长ID
        /// </summary>
        public virtual int EXAM_PREF_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 考试ID
        /// </summary>
        public virtual int? EXAM_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户ID
        /// </summary>
        public virtual string USER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime? CREATE_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 最后考试时间
        /// </summary>
        public virtual DateTime? LAST_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 总共考试时间
        /// </summary>
        public virtual int? TOTAL_TIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 最后考试分数
        /// </summary>
        public virtual decimal? LAST_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 考试最高分
        /// </summary>
        public virtual decimal? HIGH_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 考试次数
        /// </summary>
        public virtual int? ATTEMPT_NUMBER
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
        /// 唯一编号
        /// </summary>
        public virtual string CHW_SESSION_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 考试学分
        /// </summary>
        public virtual decimal? USER_CREDIT_HOUR
        {
            get; 
            set; 
        } 
         
           
                public CHW_EXAM_PREF()
        {
        
        }
   
    }
    
}
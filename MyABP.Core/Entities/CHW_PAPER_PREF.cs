using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //考试记录表
        public class CHW_PAPER_PREF:Entity
    {
    
          /// <summary>
        /// 自增长ID
        /// </summary>
        public virtual int PAPER_PREF_ID
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
        /// 试卷ID
        /// </summary>
        public virtual int? PAPER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户名
        /// </summary>
        public virtual string USER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 开始时间
        /// </summary>
        public virtual DateTime? START_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 结束时间
        /// </summary>
        public virtual DateTime? END_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 总时长
        /// </summary>
        public virtual int? TOTAL_TIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 得分
        /// </summary>
        public virtual decimal? SCORE
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
        /// CHW_PAPER_TYPE
        /// </summary>
        public virtual int? CHW_PAPER_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TOP_PAPER_ID
        /// </summary>
        public virtual int? TOP_PAPER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 满分
        /// </summary>
        public virtual decimal? FULL_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PARENT_ID
        /// </summary>
        public virtual int? PARENT_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// paper_item_order
        /// </summary>
        public virtual int? paper_item_order
        {
            get; 
            set; 
        } 
         
           
                public CHW_PAPER_PREF()
        {
        
        }
   
    }
    
}
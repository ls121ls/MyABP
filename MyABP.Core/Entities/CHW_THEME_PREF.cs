using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //试题答题表
        public class CHW_THEME_PREF:Entity
    {
    
          /// <summary>
        /// 自增长ID
        /// </summary>
        public virtual int THEME_PREF_ID
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
        /// TOP_PAPER_ID
        /// </summary>
        public virtual int? TOP_PAPER_ID
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
        /// 试题ID
        /// </summary>
        public virtual int? THEME_ID
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
        /// 正确答案
        /// </summary>
        public virtual string RIGHT_ANSWER
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 分数
        /// </summary>
        public virtual decimal? SCORE
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
        /// THEME_FLAG
        /// </summary>
        public virtual int? THEME_FLAG
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 作答答案
        /// </summary>
        public virtual string ANSWER
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
         
           
        /// <summary>
        /// CREDIT_HOUR
        /// </summary>
        public virtual decimal? CREDIT_HOUR
        {
            get; 
            set; 
        } 
         
           
                public CHW_THEME_PREF()
        {
        
        }
   
    }
    
}
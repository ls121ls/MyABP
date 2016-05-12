using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //投票结果
        public class JY_PollResult:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual int id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 问题编号
        /// </summary>
        public virtual int? QuestionId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 选项编号
        /// </summary>
        public virtual int? OptionId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 选项回答内容
        /// </summary>
        public virtual string OptionValue
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户编号
        /// </summary>
        public virtual int? User_NM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 提交日期
        /// </summary>
        public virtual DateTime? PostDate
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课程编号
        /// </summary>
        public virtual decimal? courseId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// score
        /// </summary>
        public virtual int score
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// state
        /// </summary>
        public virtual int state
        {
            get; 
            set; 
        } 
         
           
                public JY_PollResult()
        {
        
        }
   
    }
    
}
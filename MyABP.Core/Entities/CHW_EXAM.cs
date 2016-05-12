using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //考试主体表
        public class CHW_EXAM:Entity
    {
    
          /// <summary>
        /// 考试ID
        /// </summary>
        public virtual int EXAM_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 考试名次
        /// </summary>
        public virtual string EXAM_TITLE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 考试类型
        /// </summary>
        public virtual int? EXAM_TYPE
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
        /// 最后修改时间
        /// </summary>
        public virtual DateTime? LAST_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建者
        /// </summary>
        public virtual string AUTHOR_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建者编号
        /// </summary>
        public virtual int? CREATE_USER
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 考试描述
        /// </summary>
        public virtual string EXAM_DESC
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 时间限制
        /// </summary>
        public virtual int? TIME_LIMIT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 作答对象限制
        /// </summary>
        public virtual int? OBJ_LIMIT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 次数限制
        /// </summary>
        public virtual int? ATTEMPT_LIMIT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// EXAM_STATUS
        /// </summary>
        public virtual int? EXAM_STATUS
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
        /// 作答完毕是否能查看答案
        /// </summary>
        public virtual int? answer_flag
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否公布
        /// </summary>
        public virtual int? PUBLISHED
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 考试学分
        /// </summary>
        public virtual decimal? CREDIT_HOUR
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否随机排序
        /// </summary>
        public virtual int? random
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// answer_view
        /// </summary>
        public virtual int? answer_view
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课程ID
        /// </summary>
        public virtual int? course_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 及格分
        /// </summary>
        public virtual decimal? pass_score
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Portal_Value_NBR
        /// </summary>
        public virtual int? Portal_Value_NBR
        {
            get; 
            set; 
        } 
         
           
                public CHW_EXAM()
        {
        
        }
   
    }
    
}
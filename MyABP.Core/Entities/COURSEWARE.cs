using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //课程表
        public class COURSEWARE:Entity
    {
    
          /// <summary>
        /// 状态(0下线,1上线)
        /// </summary>
        public virtual decimal? STATUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 自增长编号
        /// </summary>
        public virtual decimal COURSE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课件名称
        /// </summary>
        public virtual string COURSE_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课件类型
        /// </summary>
        public virtual string MENTOR_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课件创建日期
        /// </summary>
        public virtual DateTime COURSE_CREATEDATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课件表现形式
        /// </summary>
        public virtual decimal? TYPE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课件公司编号
        /// </summary>
        public virtual string COURSE_NUMBER
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// MASTERY_SCORE
        /// </summary>
        public virtual decimal? MASTERY_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课件内容简介
        /// </summary>
        public virtual string DESCRIPTION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LIMIT_TIME
        /// </summary>
        public virtual int? LIMIT_TIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AUTO_OVER
        /// </summary>
        public virtual int? AUTO_OVER
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 必修/选修
        /// </summary>
        public virtual int? AUTO_REG
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AUTHLIMIT
        /// </summary>
        public virtual int? AUTHLIMIT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 看完课程是否直接给学分
        /// </summary>
        public virtual int? COURSE_FLAG
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// course_price
        /// </summary>
        public virtual decimal? course_price
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否私有课程
        /// </summary>
        public virtual int? distributed_flag
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// content_source
        /// </summary>
        public virtual string content_source
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 关联考试ID
        /// </summary>
        public virtual int? exam_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课件学分
        /// </summary>
        public virtual decimal? credit_hour
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课程时长
        /// </summary>
        public virtual decimal? duration
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 授课人
        /// </summary>
        public virtual string teachername
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 置顶系数
        /// </summary>
        public virtual int? topnum
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课件图片
        /// </summary>
        public virtual string COURSE_IMG
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
         
           
        /// <summary>
        /// comments_score
        /// </summary>
        public virtual decimal comments_score
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// year
        /// </summary>
        public virtual string year
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Download_Url
        /// </summary>
        public virtual string Download_Url
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Online_Url
        /// </summary>
        public virtual string Online_Url
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Gold
        /// </summary>
        public virtual decimal? Gold
        {
            get; 
            set; 
        } 
         
           
                public COURSEWARE()
        {
        
        }
   
    }
    
}
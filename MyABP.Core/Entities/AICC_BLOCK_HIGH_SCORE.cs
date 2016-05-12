using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC选课记录表
        public class AICC_BLOCK_HIGH_SCORE:Entity
    {
    
          /// <summary>
        /// BLOCK_HIGH_NUM
        /// </summary>
        public virtual decimal BLOCK_HIGH_NUM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 公司课程编号
        /// </summary>
        public virtual string COURSE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SYSTEM_ID
        /// </summary>
        public virtual string SYSTEM_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 学员用户名
        /// </summary>
        public virtual string STUDENT_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// HIGH_SCORE
        /// </summary>
        public virtual string HIGH_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 最后一次播放时间
        /// </summary>
        public virtual string LAST_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PREM_SCORE
        /// </summary>
        public virtual string PREM_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 第一次播放时间
        /// </summary>
        public virtual DateTime? FIRST_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LAST_DATE
        /// </summary>
        public virtual DateTime? LAST_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SESSION_ID
        /// </summary>
        public virtual string SESSION_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 某些课件的续读位置
        /// </summary>
        public virtual string DEVELOPER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// HIGH_STATUS
        /// </summary>
        public virtual string HIGH_STATUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LAST_STATUS
        /// </summary>
        public virtual string LAST_STATUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 学习进度
        /// </summary>
        public virtual decimal? BROWSE_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// BROWSE_COMP_DATE
        /// </summary>
        public virtual string BROWSE_COMP_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课程播放次数
        /// </summary>
        public virtual int? ATTEMPT_NUMBER
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 总学习时间
        /// </summary>
        public virtual string TOTAL_TIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SCORE_FLAG
        /// </summary>
        public virtual int? SCORE_FLAG
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// DCS节点
        /// </summary>
        public virtual string DCS_SECTIONS
        {
            get; 
            set; 
        } 
         
           
                public AICC_BLOCK_HIGH_SCORE()
        {
        
        }
   
    }
    
}
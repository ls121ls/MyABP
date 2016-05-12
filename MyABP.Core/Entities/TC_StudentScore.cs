using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //TC_StudentScore
        public class TC_StudentScore:Entity
    {
    
          /// <summary>
        /// ID
        /// </summary>
        public virtual int ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CreateTime
        /// </summary>
        public virtual DateTime? CreateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UpdateTime
        /// </summary>
        public virtual DateTime? UpdateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// StudentNM
        /// </summary>
        public virtual int? StudentNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TCID
        /// </summary>
        public virtual int? TCID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Score
        /// </summary>
        public virtual decimal? Score
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 分类ID
        /// </summary>
        public virtual int? ScoreType
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 不开班的学分来源名称
        /// </summary>
        public virtual string ScoreSource
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// StudentStartTime
        /// </summary>
        public virtual DateTime? StudentStartTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// StudentEndTime
        /// </summary>
        public virtual DateTime? StudentEndTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 额外分，扣分备注
        /// </summary>
        public virtual string Remark
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 状态，枚举
        /// </summary>
        public virtual int? State
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// StudyDays
        /// </summary>
        public virtual int? StudyDays
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AbsenceDays
        /// </summary>
        public virtual int? AbsenceDays
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ExtraScore
        /// </summary>
        public virtual decimal? ExtraScore
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AttachUrl
        /// </summary>
        public virtual string AttachUrl
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CreateUserNM
        /// </summary>
        public virtual int? CreateUserNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LearningState
        /// </summary>
        public virtual int? LearningState
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UpdateState
        /// </summary>
        public virtual int? UpdateState
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AdminUpdateState
        /// </summary>
        public virtual int? AdminUpdateState
        {
            get; 
            set; 
        } 
         
           
                public TC_StudentScore()
        {
        
        }
   
    }
    
}
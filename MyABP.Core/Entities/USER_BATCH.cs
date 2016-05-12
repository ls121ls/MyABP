using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //考核批次表
        public class USER_BATCH:Entity
    {
    
          /// <summary>
        /// 批次名称
        /// </summary>
        public virtual string BATCH_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 必修课规定学分
        /// </summary>
        public virtual decimal? REQUIRED_CREDIT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 指定课规定学分
        /// </summary>
        public virtual decimal? APPOINT_CREDIT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 规定总学分
        /// </summary>
        public virtual decimal? TOTAL_CREDIT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 开始时间
        /// </summary>
        public virtual DateTime? STARTTIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 结束时间
        /// </summary>
        public virtual DateTime? ENDTIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime? CREATETIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string SUMMARY
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 状态
        /// </summary>
        public virtual int? BATCH_STATUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 所属平台
        /// </summary>
        public virtual int? Portal_Value_NBR
        {
            get; 
            set; 
        } 
         
           
                public USER_BATCH()
        {
        
        }
   
    }
    
}
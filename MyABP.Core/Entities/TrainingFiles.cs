using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //TrainingFiles
        public class TrainingFiles:Entity
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
        /// UserID
        /// </summary>
        public virtual string UserID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 培训班名称
        /// </summary>
        public virtual string ClassName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 开始时间
        /// </summary>
        public virtual DateTime? StartTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 结束时间
        /// </summary>
        public virtual DateTime? EndTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Days
        /// </summary>
        public virtual decimal? Days
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 主办单位
        /// </summary>
        public virtual string Unit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 培训地点
        /// </summary>
        public virtual string Place
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
        /// EditUserID
        /// </summary>
        public virtual string EditUserID
        {
            get; 
            set; 
        } 
         
           
                public TrainingFiles()
        {
        
        }
   
    }
    
}
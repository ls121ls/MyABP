using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //通知公告表
        public class JY_Notice:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual int NoticeId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 通知公告标题
        /// </summary>
        public virtual string Title
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 通知内容
        /// </summary>
        public virtual string Content
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 通知公告作者
        /// </summary>
        public virtual string Author
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Level
        /// </summary>
        public virtual int? Level
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// type
        /// </summary>
        public virtual int? type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 通知公告是否显示
        /// </summary>
        public virtual bool IsShow
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 通知公告提交时间
        /// </summary>
        public virtual DateTime? PostTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 通知公告点击数
        /// </summary>
        public virtual int? ClickNumber
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// fujian
        /// </summary>
        public virtual string fujian
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
        /// attUrl
        /// </summary>
        public virtual string attUrl
        {
            get; 
            set; 
        } 
         
           
                public JY_Notice()
        {
        
        }
   
    }
    
}
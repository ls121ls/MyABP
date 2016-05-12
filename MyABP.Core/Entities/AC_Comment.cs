using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AC_Comment
        public class AC_Comment:Entity
    {
    
          /// <summary>
        /// 标示
        /// </summary>
        public virtual int ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 类型
        /// </summary>
        public virtual int Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 父ID 做二级回复用
        /// </summary>
        public virtual int? ParentId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 回复内容
        /// </summary>
        public virtual string Content
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 评分
        /// </summary>
        public virtual int? Rate
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 回复用户
        /// </summary>
        public virtual int StudentNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 状态
        /// </summary>
        public virtual int? State
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// HistoryID
        /// </summary>
        public virtual int? HistoryID
        {
            get; 
            set; 
        } 
         
           
                public AC_Comment()
        {
        
        }
   
    }
    
}
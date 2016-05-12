using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //文章表
        public class JY_Article:Entity
    {
    
          /// <summary>
        /// 自增长编号
        /// </summary>
        public virtual int id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 文章标题
        /// </summary>
        public virtual string title
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 文章作者
        /// </summary>
        public virtual string Author
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 文章来源
        /// </summary>
        public virtual string source
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 文章正文
        /// </summary>
        public virtual string content
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// url
        /// </summary>
        public virtual string url
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 文章创建时间
        /// </summary>
        public virtual DateTime? time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 文章类型
        /// </summary>
        public virtual int? Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 文章点击数
        /// </summary>
        public virtual int? ClickNumber
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
        /// TopNum
        /// </summary>
        public virtual int? TopNum
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Status
        /// </summary>
        public virtual int? Status
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Description
        /// </summary>
        public virtual string Description
        {
            get; 
            set; 
        } 
         
           
                public JY_Article()
        {
        
        }
   
    }
    
}
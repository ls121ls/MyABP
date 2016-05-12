using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //记录
        public class AC_ArticleCategory:Entity
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
        /// 主题父ID
        /// </summary>
        public virtual int ParentID
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
        /// 创建用户
        /// </summary>
        public virtual int CreateUserNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 学分
        /// </summary>
        public virtual decimal Score
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否系统分类
        /// </summary>
        public virtual int IsSystem
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 说明
        /// </summary>
        public virtual string Rmk
        {
            get; 
            set; 
        } 
         
           
                public AC_ArticleCategory()
        {
        
        }
   
    }
    
}
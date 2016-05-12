using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AC_Article
        public class AC_Article:Entity
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
        /// 标题
        /// </summary>
        public virtual string Title
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 作者
        /// </summary>
        public virtual int AuthorNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 内容
        /// </summary>
        public virtual string Content
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 类型（4大类，平台、班级、圈子、主题）
        /// </summary>
        public virtual int? Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 关联对象ID
        /// </summary>
        public virtual int? ObjID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 顶置编号
        /// </summary>
        public virtual int? TopNum
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 状态（审核、删除等..）
        /// </summary>
        public virtual int State
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 图片
        /// </summary>
        public virtual string Img
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 获得学分
        /// </summary>
        public virtual decimal? Score
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 标签
        /// </summary>
        public virtual string Tag
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 来源（转载文章、需要填写来源）
        /// </summary>
        public virtual string Source
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否允许分享
        /// </summary>
        public virtual int? IsShare
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否允许评论
        /// </summary>
        public virtual int? IsReply
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 概要
        /// </summary>
        public virtual string Outline
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 访问次数
        /// </summary>
        public virtual int? VisitCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 评论数
        /// </summary>
        public virtual int? ReplyCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 转载次数
        /// </summary>
        public virtual int? ReprintedCount
        {
            get; 
            set; 
        } 
         
           
                public AC_Article()
        {
        
        }
   
    }
    
}
using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AC_UserInfo
        public class AC_UserInfo:Entity
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
        /// 关联user表userNm
        /// </summary>
        public virtual int UserNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否允许添加好友
        /// </summary>
        public virtual int? IsAddFriend
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否显示个人信息
        /// </summary>
        public virtual int? IsSelfShow
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 个人资料
        /// </summary>
        public virtual string Comment
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 消息记录（好友有更新时新增该字段）
        /// </summary>
        public virtual int? Messages
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否首页展示
        /// </summary>
        public virtual int? IsHot
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 个人主页访问时更新该字段
        /// </summary>
        public virtual int? VisitCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 当日个人主页被访问次数
        /// </summary>
        public virtual int? TodayVisitCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否为活跃用户
        /// </summary>
        public virtual int? IsActiveUser
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LastReadTime
        /// </summary>
        public virtual DateTime? LastReadTime
        {
            get; 
            set; 
        } 
         
           
                public AC_UserInfo()
        {
        
        }
   
    }
    
}
using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //用户登录情况表
        public class USER_ONLINE_TIME:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual decimal u_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 登录时间
        /// </summary>
        public virtual DateTime? login_time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 退出时间
        /// </summary>
        public virtual DateTime? exit_time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 在线时长
        /// </summary>
        public virtual decimal? Length_time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户名
        /// </summary>
        public virtual string user_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 状态(0在线,1离线)
        /// </summary>
        public virtual string user_state
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 最后一次更新时间
        /// </summary>
        public virtual DateTime? last_time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 唯一标识
        /// </summary>
        public virtual string user_identity
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
        /// user_ip
        /// </summary>
        public virtual string user_ip
        {
            get; 
            set; 
        } 
         
           
                public USER_ONLINE_TIME()
        {
        
        }
   
    }
    
}
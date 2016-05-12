using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //直播课程列表
        public class Live_Class:Entity
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
        /// 课程名称
        /// </summary>
        public virtual string name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课堂编号
        /// </summary>
        public virtual string number
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 助教口令
        /// </summary>
        public virtual string assistantToken
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Web 端学员口令
        /// </summary>
        public virtual string studentToken
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 老师口令
        /// </summary>
        public virtual string teacherToken
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 学生客户端口令
        /// </summary>
        public virtual string studentClientToken
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 预期开始时间
        /// </summary>
        public virtual DateTime? startDate
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否允许 web 端学生加入
        /// </summary>
        public virtual string webJoin
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否允许客户端学生加入
        /// </summary>
        public virtual string clientJoin
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 失效日期（详情见 3.3）
        /// </summary>
        public virtual DateTime? invalidDate
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 老师和助教加入 URL
        /// </summary>
        public virtual string teacherJoinUrl
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 学员加入 URL
        /// </summary>
        public virtual string studentJoinUrl
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 0:大讲堂， 1：小班课， 2：私教课
        /// </summary>
        public virtual int scene
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// portal_value_nbr
        /// </summary>
        public virtual int portal_value_nbr
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 添加时间
        /// </summary>
        public virtual DateTime AddTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 老师介绍
        /// </summary>
        public virtual string speakerInfo
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课程介绍
        /// </summary>
        public virtual string scheduleInfo
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课堂持续时长（单位为分钟）
        /// </summary>
        public virtual int? duration
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 登录名
        /// </summary>
        public virtual string loginName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 密码
        /// </summary>
        public virtual string password
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ImgUrl
        /// </summary>
        public virtual string ImgUrl
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SDKID
        /// </summary>
        public virtual string SDKID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OnlineNumber
        /// </summary>
        public virtual int? OnlineNumber
        {
            get; 
            set; 
        } 
         
           
                public Live_Class()
        {
        
        }
   
    }
    
}
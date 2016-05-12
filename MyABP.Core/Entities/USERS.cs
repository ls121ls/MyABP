using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //用户表
        public class USERS:Entity
    {
    
          /// <summary>
        /// 状态(1正常,0禁止登录)
        /// </summary>
        public virtual int? USER_STATUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public virtual DateTime? LAST_LOGIN_TIME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户组编号
        /// </summary>
        public virtual decimal? USER_GROUP_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户名
        /// </summary>
        public virtual string USER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户编号
        /// </summary>
        public virtual decimal USER_NM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户类型(0超级管理员,1普通,2二级管理员)
        /// </summary>
        public virtual int? USER_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户姓名
        /// </summary>
        public virtual string USER_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 登录密码
        /// </summary>
        public virtual string USER_PWD
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// USER_PWD_QUT
        /// </summary>
        public virtual string USER_PWD_QUT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// USER_PWD_ANS
        /// </summary>
        public virtual string USER_PWD_ANS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户生日
        /// </summary>
        public virtual DateTime? USER_BRI_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 性别
        /// </summary>
        public virtual int? USER_SEX
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 电话
        /// </summary>
        public virtual string USER_TEL
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Email地址
        /// </summary>
        public virtual string USER_EMAIL
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// USER_INTRODUCE
        /// </summary>
        public virtual string USER_INTRODUCE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// USER_IP
        /// </summary>
        public virtual string USER_IP
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// USER_PROXY_IP
        /// </summary>
        public virtual string USER_PROXY_IP
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// REMARK
        /// </summary>
        public virtual string REMARK
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户职务编号
        /// </summary>
        public virtual decimal? USER_BUSINESS_NM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OTHER_ID
        /// </summary>
        public virtual decimal? OTHER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 登录次数
        /// </summary>
        public virtual int? LOGIN_TIMES
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// zz_sf
        /// </summary>
        public virtual int? zz_sf
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// zj
        /// </summary>
        public virtual int? zj
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// user_worktime
        /// </summary>
        public virtual DateTime? user_worktime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 职务
        /// </summary>
        public virtual string OTHER_ID_1
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OTHER_ID_2
        /// </summary>
        public virtual string OTHER_ID_2
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OTHER_ID_3
        /// </summary>
        public virtual string OTHER_ID_3
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否参加前台排行,0不参加,1参加
        /// </summary>
        public virtual string OTHER_ID_4
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OTHER_ID_5
        /// </summary>
        public virtual string OTHER_ID_5
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 学历编号
        /// </summary>
        public virtual int? xueli_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Degree_id
        /// </summary>
        public virtual int? Degree_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 身份证
        /// </summary>
        public virtual string id_card
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 手机号码
        /// </summary>
        public virtual string MobileNo
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UserNO
        /// </summary>
        public virtual string UserNO
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PhotoUrl
        /// </summary>
        public virtual string PhotoUrl
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Title
        /// </summary>
        public virtual int? Title
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 民族编号
        /// </summary>
        public virtual string mingzu
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// fristxueli
        /// </summary>
        public virtual int? fristxueli
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// post_id
        /// </summary>
        public virtual int? post_id
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
        /// CREATE_DATE
        /// </summary>
        public virtual DateTime? CREATE_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Gold
        /// </summary>
        public virtual decimal? Gold
        {
            get; 
            set; 
        } 
         
           
                public USERS()
        {
        
        }
   
    }
    
}
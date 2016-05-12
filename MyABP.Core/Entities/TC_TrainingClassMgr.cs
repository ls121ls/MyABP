using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //TC_TrainingClassMgr
        public class TC_TrainingClassMgr:Entity
    {
    
          /// <summary>
        /// tc_ID
        /// </summary>
        public virtual int tc_ID
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
        /// 名称
        /// </summary>
        public virtual string tc_Name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 报名开始
        /// </summary>
        public virtual DateTime? tc_SignStartTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 报名截止
        /// </summary>
        public virtual DateTime? tc_SignEndTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 类型
        /// </summary>
        public virtual int? tc_ClassTypeID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 教学计划
        /// </summary>
        public virtual string tc_Plan
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 主办单位
        /// </summary>
        public virtual string tc_HostedGroup
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 主办地
        /// </summary>
        public virtual string tc_HostedAdd
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 开始时间
        /// </summary>
        public virtual DateTime? tc_StartTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 结束时间
        /// </summary>
        public virtual DateTime? tc_EndTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 状态
        /// </summary>
        public virtual string tc_State
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 简介
        /// </summary>
        public virtual string tc_Synopsis
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 建立者
        /// </summary>
        public virtual int? tc_CreateUserNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 班主任
        /// </summary>
        public virtual int? tc_AdviserUserNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 名额
        /// </summary>
        public virtual int? tc_Total
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 培训对象
        /// </summary>
        public virtual string tc_Target
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 班委
        /// </summary>
        public virtual string tc_Remark
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 0境内，1境外
        /// </summary>
        public virtual int? tc_Out
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否发布到前台,0否,1是
        /// </summary>
        public virtual int? tc_Publish
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 父级
        /// </summary>
        public virtual int? tc_MainID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 期次
        /// </summary>
        public virtual int? tc_Term
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 学习天数
        /// </summary>
        public virtual int? tc_StudyDay
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 班级层次
        /// </summary>
        public virtual int? tc_Class
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// tc_AuditState
        /// </summary>
        public virtual int? tc_AuditState
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// StopUpdateScore
        /// </summary>
        public virtual int? StopUpdateScore
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// StopUpdateState
        /// </summary>
        public virtual int? StopUpdateState
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// tc_ClassCredits
        /// </summary>
        public virtual decimal? tc_ClassCredits
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// tc_IsRegistration
        /// </summary>
        public virtual int? tc_IsRegistration
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 结业方式(0手动，1自动)
        /// </summary>
        public virtual int? tc_CertificateWay
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 选修课达标数量
        /// </summary>
        public virtual int? tc_RulesNumber
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// tc_ClassType
        /// </summary>
        public virtual int? tc_ClassType
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
         
           
                public TC_TrainingClassMgr()
        {
        
        }
   
    }
    
}
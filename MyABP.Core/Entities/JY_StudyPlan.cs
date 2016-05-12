using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //学习计划表
        public class JY_StudyPlan:Entity
    {
    
          /// <summary>
        /// 用户编号
        /// </summary>
        public virtual decimal User_Nm
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课程编号
        /// </summary>
        public virtual decimal Course_Id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 完成时间
        /// </summary>
        public virtual DateTime? Finish_Time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 开始提醒时间
        /// </summary>
        public virtual DateTime? Remind_Time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 提醒类型
        /// </summary>
        public virtual int? Remind_Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 计划描述
        /// </summary>
        public virtual string Description
        {
            get; 
            set; 
        } 
         
           
                public JY_StudyPlan()
        {
        
        }
   
    }
    
}
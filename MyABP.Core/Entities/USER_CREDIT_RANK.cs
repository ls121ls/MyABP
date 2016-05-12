using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //学分排行表
        public class USER_CREDIT_RANK:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual int id
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
        /// 用户姓名
        /// </summary>
        public virtual string user_name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户编号
        /// </summary>
        public virtual int? User_nm
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课程学分
        /// </summary>
        public virtual decimal? cCredit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 考试学分
        /// </summary>
        public virtual decimal? eCredit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 总学分
        /// </summary>
        public virtual decimal? TotalCredit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 选课数
        /// </summary>
        public virtual decimal? total
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
        /// lastdate
        /// </summary>
        public virtual DateTime? lastdate
        {
            get; 
            set; 
        } 
         
           
                public USER_CREDIT_RANK()
        {
        
        }
   
    }
    
}
using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //用户学习次数排行
        public class USER_STUDY_TIMES_RANK:Entity
    {
    
          /// <summary>
        /// id
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
        /// 学习次数
        /// </summary>
        public virtual int? Total
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
         
           
                public USER_STUDY_TIMES_RANK()
        {
        
        }
   
    }
    
}
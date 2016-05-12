using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //JY_ErrorLog
        public class JY_ErrorLog:Entity
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
        /// 用户IP
        /// </summary>
        public virtual string LastUserIP
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 发生时间
        /// </summary>
        public virtual DateTime? ErrorTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        ///  发生异常页
        /// </summary>
        public virtual string ErrorPage
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 异常信息
        /// </summary>
        public virtual string ErrorMessage
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 错误源
        /// </summary>
        public virtual string ErrorSource
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 堆栈信息
        /// </summary>
        public virtual string ErrorStackTrace
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 错误次数
        /// </summary>
        public virtual int? ErrorTimes
        {
            get; 
            set; 
        } 
         
           
                public JY_ErrorLog()
        {
        
        }
   
    }
    
}
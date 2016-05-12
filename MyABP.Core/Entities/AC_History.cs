using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AC_History
        public class AC_History:Entity
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
        /// 创建用户
        /// </summary>
        public virtual int CreateUserNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 主体ID
        /// </summary>
        public virtual int Operation
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 类型
        /// </summary>
        public virtual int Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 操作内容（存动态展示的html）
        /// </summary>
        public virtual string Rmk
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// MainID
        /// </summary>
        public virtual int? MainID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// lastupdatetime
        /// </summary>
        public virtual DateTime? lastupdatetime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// State
        /// </summary>
        public virtual int State
        {
            get; 
            set; 
        } 
         
           
                public AC_History()
        {
        
        }
   
    }
    
}
using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AC_PhotoList
        public class AC_PhotoList:Entity
    {
    
          /// <summary>
        /// 编号
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
        /// 创建用户编号
        /// </summary>
        public virtual int CreateUserNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 组编号
        /// </summary>
        public virtual int? GroupID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 标题
        /// </summary>
        public virtual string Title
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 路径
        /// </summary>
        public virtual string Path
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 备注（简介之类）
        /// </summary>
        public virtual string Remarks
        {
            get; 
            set; 
        } 
         
           
                public AC_PhotoList()
        {
        
        }
   
    }
    
}
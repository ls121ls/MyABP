using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AC_CircleMgr
        public class AC_CircleMgr:Entity
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
        /// 圈子标题
        /// </summary>
        public virtual string Title
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 说明
        /// </summary>
        public virtual string Comment
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否需要审核
        /// </summary>
        public virtual int? IsAudit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否通过审核等
        /// </summary>
        public virtual int? State
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 置顶编号
        /// </summary>
        public virtual int? TopNum
        {
            get; 
            set; 
        } 
         
           
                public AC_CircleMgr()
        {
        
        }
   
    }
    
}
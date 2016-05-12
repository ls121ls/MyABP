using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AC_RelationshipMgr
        public class AC_RelationshipMgr:Entity
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
        /// 关系类型（好友、圈子等）
        /// </summary>
        public virtual int Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 关系对象ID
        /// </summary>
        public virtual int ObjID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 状态（验证、待验证）
        /// </summary>
        public virtual int State
        {
            get; 
            set; 
        } 
         
           
                public AC_RelationshipMgr()
        {
        
        }
   
    }
    
}
using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //用户组表
        public class USER_GROUP:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual decimal USER_GROUP_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户组名称
        /// </summary>
        public virtual string USER_GROUP_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// USER_GROUP_CODE
        /// </summary>
        public virtual string USER_GROUP_CODE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 父用户组编号
        /// </summary>
        public virtual decimal? PER_USER_GROUP
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// duchy
        /// </summary>
        public virtual int? duchy
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 父用户组编号
        /// </summary>
        public virtual int? G_ParentID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 排序
        /// </summary>
        public virtual int? G_ShowOrder
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 层级
        /// </summary>
        public virtual int? G_Level
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 子组数量
        /// </summary>
        public virtual int? G_ChildCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否删除
        /// </summary>
        public virtual int? G_Delete
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
         
           
                public USER_GROUP()
        {
        
        }
   
    }
    
}
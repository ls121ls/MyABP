using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //标签表
        public class Designator:Entity
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
        /// 标签名称
        /// </summary>
        public virtual string Name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 标签描述
        /// </summary>
        public virtual string Description
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 上一级ID
        /// </summary>
        public virtual int ParentId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 排序ID
        /// </summary>
        public virtual int SortId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 备注字
        /// </summary>
        public virtual string Remark
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsDelete
        /// </summary>
        public virtual bool IsDelete
        {
            get; 
            set; 
        } 
         
           
                public Designator()
        {
        
        }
   
    }
    
}
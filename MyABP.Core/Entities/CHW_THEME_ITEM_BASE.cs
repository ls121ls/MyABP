using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //试题选项表
        public class CHW_THEME_ITEM_BASE:Entity
    {
    
          /// <summary>
        /// 选项ID
        /// </summary>
        public virtual int THEME_ITEM_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 选项内容
        /// </summary>
        public virtual string THEME_ITEM_TITLE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试题ID
        /// </summary>
        public virtual int? THEME_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 排序
        /// </summary>
        public virtual int? THEME_ITEM_ORDER
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// THEME_ITEM_FLAG
        /// </summary>
        public virtual string THEME_ITEM_FLAG
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CHW_PAPER_TYPE
        /// </summary>
        public virtual int? CHW_PAPER_TYPE
        {
            get; 
            set; 
        } 
         
           
                public CHW_THEME_ITEM_BASE()
        {
        
        }
   
    }
    
}
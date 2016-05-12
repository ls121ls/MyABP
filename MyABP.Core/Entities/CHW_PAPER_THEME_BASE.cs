using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //试卷试题表
        public class CHW_PAPER_THEME_BASE:Entity
    {
    
          /// <summary>
        /// 自增长ID
        /// </summary>
        public virtual int PAPER_THEME_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试卷ID
        /// </summary>
        public virtual int? PAPER_ID
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
        /// 试题排序
        /// </summary>
        public virtual int? PAPER_ITEM_ORDER
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试题分数
        /// </summary>
        public virtual decimal? THEME_SCORE_VALUE
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
         
           
                public CHW_PAPER_THEME_BASE()
        {
        
        }
   
    }
    
}
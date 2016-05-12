using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //试卷表
        public class CHW_PAPER:Entity
    {
    
          /// <summary>
        /// 试卷ID
        /// </summary>
        public virtual int PAPER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试卷名称
        /// </summary>
        public virtual string PAPER_TITLE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PARENT_ID
        /// </summary>
        public virtual int? PARENT_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PAPER_ITEM_ORDER
        /// </summary>
        public virtual int? PAPER_ITEM_ORDER
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime? CREATE_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public virtual DateTime? LAST_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建者
        /// </summary>
        public virtual string AUTHOR_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建者编号
        /// </summary>
        public virtual int? CREATE_USER
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试卷语言
        /// </summary>
        public virtual int? OBJ_LANG
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试卷难度
        /// </summary>
        public virtual int? OBJ_LEVEL
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 时间限制
        /// </summary>
        public virtual int? TIME_LIMIT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试卷总分
        /// </summary>
        public virtual decimal? PAPER_SCORE_VALUE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试卷描述
        /// </summary>
        public virtual string PAPER_DESC
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试卷类型(1是样卷)
        /// </summary>
        public virtual int? CHW_PAPER_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 题数
        /// </summary>
        public virtual int? PAPER_THEME_COUNT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试卷类型(新建一份or随机生成or从样卷复制)
        /// </summary>
        public virtual int? PAPER_CSTYLE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PAPER_TYPE
        /// </summary>
        public virtual int? PAPER_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试卷模式(单题还是整版)
        /// </summary>
        public virtual int? PAPER_MODEL
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否公布
        /// </summary>
        public virtual int? PUBLISHED
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 判断题数量
        /// </summary>
        public virtual int? JUDGE_COUNT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 单选题数量
        /// </summary>
        public virtual int? SINGLE_COUNT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 多选题数量
        /// </summary>
        public virtual int? MORE_COUNT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ThemJson
        /// </summary>
        public virtual string ThemJson
        {
            get; 
            set; 
        } 
         
           
                public CHW_PAPER()
        {
        
        }
   
    }
    
}
﻿using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //试题表
        public class CHW_THEME_BASE:Entity
    {
    
          /// <summary>
        /// 试题ID
        /// </summary>
        public virtual int THEME_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试题标题
        /// </summary>
        public virtual string THEME_TITLE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试题类型
        /// </summary>
        public virtual int THEME_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试题分类
        /// </summary>
        public virtual int CONTENT_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 答案
        /// </summary>
        public virtual string THEME_SOLUTION
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建日期
        /// </summary>
        public virtual DateTime? CREATE_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 最后修改日期
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
        /// 语言
        /// </summary>
        public virtual int? OBJ_LANG
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 难度
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
        /// 试题描述
        /// </summary>
        public virtual string THEME_DESC
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 关键词
        /// </summary>
        public virtual string THEME_KEYWORDS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CHW_PAPER_TYPE
        /// </summary>
        public virtual int CHW_PAPER_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 试题分数
        /// </summary>
        public virtual string ThemeScore
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsOpen
        /// </summary>
        public virtual int? IsOpen
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsCompulsory
        /// </summary>
        public virtual int? IsCompulsory
        {
            get; 
            set; 
        } 
         
           
                public CHW_THEME_BASE()
        {
        
        }
   
    }
    
}
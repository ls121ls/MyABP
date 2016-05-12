using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //CHW_PAPER_BASE
        public class CHW_PAPER_BASE:Entity
    {
    
          /// <summary>
        /// PAPER_ID
        /// </summary>
        public virtual int PAPER_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PAPER_TITLE
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
        /// CREATE_DATE
        /// </summary>
        public virtual DateTime? CREATE_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LAST_DATE
        /// </summary>
        public virtual DateTime? LAST_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AUTHOR_NAME
        /// </summary>
        public virtual string AUTHOR_NAME
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CREATE_USER
        /// </summary>
        public virtual int? CREATE_USER
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OBJ_LANG
        /// </summary>
        public virtual int? OBJ_LANG
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OBJ_LEVEL
        /// </summary>
        public virtual int? OBJ_LEVEL
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TIME_LIMIT
        /// </summary>
        public virtual int? TIME_LIMIT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PAPER_SCORE_VALUE
        /// </summary>
        public virtual int? PAPER_SCORE_VALUE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PAPER_DESC
        /// </summary>
        public virtual string PAPER_DESC
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
         
           
        /// <summary>
        /// PAPER_TYPE
        /// </summary>
        public virtual int? PAPER_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// paper_theme_count
        /// </summary>
        public virtual int? paper_theme_count
        {
            get; 
            set; 
        } 
         
           
                public CHW_PAPER_BASE()
        {
        
        }
   
    }
    
}
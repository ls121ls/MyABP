using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //chw_theme_base_bak
        public class chw_theme_base_bak:Entity
    {
    
          /// <summary>
        /// THEME_ID
        /// </summary>
        public virtual int THEME_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// THEME_TITLE
        /// </summary>
        public virtual string THEME_TITLE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// THEME_TYPE
        /// </summary>
        public virtual int THEME_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CONTENT_TYPE
        /// </summary>
        public virtual int CONTENT_TYPE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// THEME_SOLUTION
        /// </summary>
        public virtual string THEME_SOLUTION
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
        /// THEME_DESC
        /// </summary>
        public virtual string THEME_DESC
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// THEME_KEYWORDS
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
        /// ThemeScore
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
         
           
                public chw_theme_base_bak()
        {
        
        }
   
    }
    
}
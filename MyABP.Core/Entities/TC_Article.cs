using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //TC_Article
        public class TC_Article:Entity
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
        /// CreateTime
        /// </summary>
        public virtual DateTime? CreateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UpdateTime
        /// </summary>
        public virtual DateTime? UpdateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Title
        /// </summary>
        public virtual string Title
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AuthorNM
        /// </summary>
        public virtual int? AuthorNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Content
        /// </summary>
        public virtual string Content
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Type
        /// </summary>
        public virtual int? Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TCID
        /// </summary>
        public virtual int? TCID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TopNum
        /// </summary>
        public virtual int? TopNum
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// State
        /// </summary>
        public virtual int? State
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Img
        /// </summary>
        public virtual string Img
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Score
        /// </summary>
        public virtual decimal? Score
        {
            get; 
            set; 
        } 
         
           
                public TC_Article()
        {
        
        }
   
    }
    
}
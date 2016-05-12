using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //JY_Comment
        public class JY_Comment:Entity
    {
    
          /// <summary>
        /// ParentId
        /// </summary>
        public virtual int? ParentId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TargetId
        /// </summary>
        public virtual int? TargetId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CommentType
        /// </summary>
        public virtual int? CommentType
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Visible
        /// </summary>
        public virtual bool Visible
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Audit
        /// </summary>
        public virtual int? Audit
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
        /// Title
        /// </summary>
        public virtual string Title
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
        /// UserId
        /// </summary>
        public virtual string UserId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UserName
        /// </summary>
        public virtual string UserName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UserEmail
        /// </summary>
        public virtual string UserEmail
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Indent
        /// </summary>
        public virtual int? Indent
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// DateAdded
        /// </summary>
        public virtual DateTime? DateAdded
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ImgUrl
        /// </summary>
        public virtual string ImgUrl
        {
            get; 
            set; 
        } 
         
           
                public JY_Comment()
        {
        
        }
   
    }
    
}
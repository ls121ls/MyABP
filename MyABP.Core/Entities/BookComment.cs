using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //BookComment
        public class BookComment:Entity
    {
    
          /// <summary>
        /// CommentID
        /// </summary>
        public virtual int CommentID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// BookNameID
        /// </summary>
        public virtual int? BookNameID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UserID
        /// </summary>
        public virtual string UserID
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
        /// createtime
        /// </summary>
        public virtual DateTime? createtime
        {
            get; 
            set; 
        } 
         
           
                public BookComment()
        {
        
        }
   
    }
    
}
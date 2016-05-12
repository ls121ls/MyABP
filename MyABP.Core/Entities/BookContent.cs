using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //BookContent
        public class BookContent:Entity
    {
    
          /// <summary>
        /// BookContentID
        /// </summary>
        public virtual int BookContentID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// BookTitleID
        /// </summary>
        public virtual int? BookTitleID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// content
        /// </summary>
        public virtual string content
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
        /// IsActive
        /// </summary>
        public virtual int? IsActive
        {
            get; 
            set; 
        } 
         
           
                public BookContent()
        {
        
        }
   
    }
    
}
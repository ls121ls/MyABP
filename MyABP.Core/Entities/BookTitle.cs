using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //BookTitle
        public class BookTitle:Entity
    {
    
          /// <summary>
        /// BookTitleID
        /// </summary>
        public virtual int BookTitleID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// BookNameID
        /// </summary>
        public virtual int BookNameID
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
        /// uploadName
        /// </summary>
        public virtual string uploadName
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
         
           
        /// <summary>
        /// OrderColunm
        /// </summary>
        public virtual int? OrderColunm
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PerateID
        /// </summary>
        public virtual int? PerateID
        {
            get; 
            set; 
        } 
         
           
                public BookTitle()
        {
        
        }
   
    }
    
}
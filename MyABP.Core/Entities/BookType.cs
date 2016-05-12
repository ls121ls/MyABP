using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //BookType
        public class BookType:Entity
    {
    
          /// <summary>
        /// BookTypeID
        /// </summary>
        public virtual int BookTypeID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// BookTypeName
        /// </summary>
        public virtual string BookTypeName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ParentID
        /// </summary>
        public virtual int? ParentID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Remark
        /// </summary>
        public virtual string Remark
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
        /// Portal_Value_NBR
        /// </summary>
        public virtual int? Portal_Value_NBR
        {
            get; 
            set; 
        } 
         
           
                public BookType()
        {
        
        }
   
    }
    
}
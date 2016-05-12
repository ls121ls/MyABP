using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //bookName
        public class bookName:Entity
    {
    
          /// <summary>
        /// BookNameID
        /// </summary>
        public virtual int BookNameID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// BookTypeID
        /// </summary>
        public virtual int? BookTypeID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Name
        /// </summary>
        public virtual string Name
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
        /// CreateTime
        /// </summary>
        public virtual DateTime? CreateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AutoName
        /// </summary>
        public virtual string AutoName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsActive
        /// </summary>
        public virtual int IsActive
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Picture
        /// </summary>
        public virtual string Picture
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ByteCount
        /// </summary>
        public virtual int? ByteCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ClickCount
        /// </summary>
        public virtual int? ClickCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// FlowerCount
        /// </summary>
        public virtual int? FlowerCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// keyname
        /// </summary>
        public virtual string keyname
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
         
           
                public bookName()
        {
        
        }
   
    }
    
}
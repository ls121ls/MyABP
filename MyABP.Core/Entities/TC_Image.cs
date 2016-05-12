using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //TC_Image
        public class TC_Image:Entity
    {
    
          /// <summary>
        /// id
        /// </summary>
        public virtual int id
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
        /// StudentNM
        /// </summary>
        public virtual int? StudentNM
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
        /// ParentId
        /// </summary>
        public virtual int? ParentId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Path
        /// </summary>
        public virtual string Path
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
        /// Desc
        /// </summary>
        public virtual string Desc
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 0下线,1正常
        /// </summary>
        public virtual int? State
        {
            get; 
            set; 
        } 
         
           
                public TC_Image()
        {
        
        }
   
    }
    
}
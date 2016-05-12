using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //班级留言表
        public class TC_Comment:Entity
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
        /// 话题或论文
        /// </summary>
        public virtual int? Type
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
        /// Content
        /// </summary>
        public virtual string Content
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Rate
        /// </summary>
        public virtual int? Rate
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
        /// 0下线，1正常
        /// </summary>
        public virtual int? State
        {
            get; 
            set; 
        } 
         
           
                public TC_Comment()
        {
        
        }
   
    }
    
}
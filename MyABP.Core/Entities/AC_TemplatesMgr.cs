using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AC_TemplatesMgr
        public class AC_TemplatesMgr:Entity
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
        /// CreateUserNM
        /// </summary>
        public virtual int? CreateUserNM
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
        /// Variable
        /// </summary>
        public virtual string Variable
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
         
           
                public AC_TemplatesMgr()
        {
        
        }
   
    }
    
}
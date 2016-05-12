using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_Group
        public class sys_Group:Entity
    {
    
          /// <summary>
        /// GroupID
        /// </summary>
        public virtual int GroupID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// G_CName
        /// </summary>
        public virtual string G_CName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// G_ParentID
        /// </summary>
        public virtual int G_ParentID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// G_ShowOrder
        /// </summary>
        public virtual int G_ShowOrder
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// G_Level
        /// </summary>
        public virtual int? G_Level
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// G_ChildCount
        /// </summary>
        public virtual int? G_ChildCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// G_Delete
        /// </summary>
        public virtual int? G_Delete
        {
            get; 
            set; 
        } 
         
           
                public sys_Group()
        {
        
        }
   
    }
    
}
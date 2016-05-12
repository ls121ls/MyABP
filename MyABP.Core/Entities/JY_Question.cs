using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //问卷问题表
        public class JY_Question:Entity
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
        /// Title
        /// </summary>
        public virtual string Title
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
         
           
        /// <summary>
        /// Target
        /// </summary>
        public virtual int? Target
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Enabled
        /// </summary>
        public virtual bool Enabled
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
         
           
                public JY_Question()
        {
        
        }
   
    }
    
}
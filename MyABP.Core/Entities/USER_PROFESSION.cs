using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //USER_PROFESSION
        public class USER_PROFESSION:Entity
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
        /// profeName
        /// </summary>
        public virtual string profeName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Userid
        /// </summary>
        public virtual string Userid
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ProfeType
        /// </summary>
        public virtual string ProfeType
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ProfeGetType
        /// </summary>
        public virtual string ProfeGetType
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ProfeGetTime
        /// </summary>
        public virtual DateTime? ProfeGetTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ProfeBookNum
        /// </summary>
        public virtual string ProfeBookNum
        {
            get; 
            set; 
        } 
         
           
                public USER_PROFESSION()
        {
        
        }
   
    }
    
}
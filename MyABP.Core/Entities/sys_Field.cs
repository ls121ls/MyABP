using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_Field
        public class sys_Field:Entity
    {
    
          /// <summary>
        /// FieldID
        /// </summary>
        public virtual int FieldID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// F_Key
        /// </summary>
        public virtual string F_Key
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// F_CName
        /// </summary>
        public virtual string F_CName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// F_Remark
        /// </summary>
        public virtual string F_Remark
        {
            get; 
            set; 
        } 
         
           
                public sys_Field()
        {
        
        }
   
    }
    
}
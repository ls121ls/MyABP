using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_FieldValue
        public class sys_FieldValue:Entity
    {
    
          /// <summary>
        /// ValueID
        /// </summary>
        public virtual int ValueID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// V_F_Key
        /// </summary>
        public virtual string V_F_Key
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// V_Text
        /// </summary>
        public virtual string V_Text
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// V_ShowOrder
        /// </summary>
        public virtual int V_ShowOrder
        {
            get; 
            set; 
        } 
         
           
                public sys_FieldValue()
        {
        
        }
   
    }
    
}
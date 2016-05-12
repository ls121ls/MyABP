using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //1
        public class sysdiagrams:Entity
    {
    
          /// <summary>
        /// name
        /// </summary>
        public virtual string name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// principal_id
        /// </summary>
        public virtual int principal_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// diagram_id
        /// </summary>
        public virtual int diagram_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// version
        /// </summary>
        public virtual int? version
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// definition
        /// </summary>
        public virtual byte[] definition
        {
            get; 
            set; 
        } 
         
           
                public sysdiagrams()
        {
        
        }
   
    }
    
}
using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //USERDEGREE
        public class USERDEGREE:Entity
    {
    
          /// <summary>
        /// Degree_id
        /// </summary>
        public virtual int Degree_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Degree_name
        /// </summary>
        public virtual string Degree_name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// per_Degree_id
        /// </summary>
        public virtual int? per_Degree_id
        {
            get; 
            set; 
        } 
         
           
                public USERDEGREE()
        {
        
        }
   
    }
    
}
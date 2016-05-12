using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //Oper_Log
        public class Oper_Log:Entity
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
        /// author
        /// </summary>
        public virtual string author
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ip
        /// </summary>
        public virtual string ip
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// oper_content
        /// </summary>
        public virtual string oper_content
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// createdate
        /// </summary>
        public virtual DateTime? createdate
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// typeid
        /// </summary>
        public virtual int? typeid
        {
            get; 
            set; 
        } 
         
           
                public Oper_Log()
        {
        
        }
   
    }
    
}
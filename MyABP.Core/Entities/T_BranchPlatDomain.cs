using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //平台域名对应表
        public class T_BranchPlatDomain:Entity
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
        /// PlatID
        /// </summary>
        public virtual int PlatID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// BP_PlatDomain_TXT
        /// </summary>
        public virtual string BP_PlatDomain_TXT
        {
            get; 
            set; 
        } 
         
           
                public T_BranchPlatDomain()
        {
        
        }
   
    }
    
}
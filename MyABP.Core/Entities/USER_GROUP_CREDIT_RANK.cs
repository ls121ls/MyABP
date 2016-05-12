using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //USER_GROUP_CREDIT_RANK
        public class USER_GROUP_CREDIT_RANK:Entity
    {
    
          /// <summary>
        /// groupid
        /// </summary>
        public virtual int groupid
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// groupname
        /// </summary>
        public virtual string groupname
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// sumcredit
        /// </summary>
        public virtual decimal? sumcredit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// argcredit
        /// </summary>
        public virtual decimal? argcredit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// usercount
        /// </summary>
        public virtual int? usercount
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
         
           
                public USER_GROUP_CREDIT_RANK()
        {
        
        }
   
    }
    
}
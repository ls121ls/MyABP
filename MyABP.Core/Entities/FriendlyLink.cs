using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //FriendlyLink
        public class FriendlyLink:Entity
    {
    
          /// <summary>
        /// FriendlyLinkId
        /// </summary>
        public virtual int FriendlyLinkId
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
        /// Link
        /// </summary>
        public virtual string Link
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TopNum
        /// </summary>
        public virtual int TopNum
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Remark
        /// </summary>
        public virtual string Remark
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
         
           
        /// <summary>
        /// ImageUrl
        /// </summary>
        public virtual string ImageUrl
        {
            get; 
            set; 
        } 
         
           
                public FriendlyLink()
        {
        
        }
   
    }
    
}
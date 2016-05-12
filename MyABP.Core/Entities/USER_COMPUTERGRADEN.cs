using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //USER_COMPUTERGRADEN
        public class USER_COMPUTERGRADEN:Entity
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
        /// UserGrad
        /// </summary>
        public virtual string UserGrad
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
        /// PassTime
        /// </summary>
        public virtual DateTime? PassTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// BookNummber
        /// </summary>
        public virtual string BookNummber
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AwardUnit
        /// </summary>
        public virtual string AwardUnit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// GetScore
        /// </summary>
        public virtual decimal? GetScore
        {
            get; 
            set; 
        } 
         
           
                public USER_COMPUTERGRADEN()
        {
        
        }
   
    }
    
}
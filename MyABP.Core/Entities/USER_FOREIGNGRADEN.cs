using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //USER_FOREIGNGRADEN
        public class USER_FOREIGNGRADEN:Entity
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
        /// LanguageType
        /// </summary>
        public virtual string LanguageType
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UserId
        /// </summary>
        public virtual string UserId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UserGrade
        /// </summary>
        public virtual string UserGrade
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
        /// UserScore
        /// </summary>
        public virtual decimal? UserScore
        {
            get; 
            set; 
        } 
         
           
                public USER_FOREIGNGRADEN()
        {
        
        }
   
    }
    
}
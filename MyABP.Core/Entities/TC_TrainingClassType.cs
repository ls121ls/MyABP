using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //TC_TrainingClassType
        public class TC_TrainingClassType:Entity
    {
    
          /// <summary>
        /// tc_Type_ID
        /// </summary>
        public virtual int tc_Type_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CreateTime
        /// </summary>
        public virtual DateTime? CreateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UpdateTime
        /// </summary>
        public virtual DateTime? UpdateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TypeName
        /// </summary>
        public virtual string TypeName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ParentID
        /// </summary>
        public virtual int? ParentID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TypeContent
        /// </summary>
        public virtual string TypeContent
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TypeRatio
        /// </summary>
        public virtual decimal? TypeRatio
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TypeMaxCredits
        /// </summary>
        public virtual decimal? TypeMaxCredits
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TypeGroup
        /// </summary>
        public virtual int? TypeGroup
        {
            get; 
            set; 
        } 
         
           
                public TC_TrainingClassType()
        {
        
        }
   
    }
    
}
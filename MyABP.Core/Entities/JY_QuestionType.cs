using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //JY_QuestionType
        public class JY_QuestionType:Entity
    {
    
          /// <summary>
        /// TargetID
        /// </summary>
        public virtual int TargetID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// typename
        /// </summary>
        public virtual string typename
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否上线
        /// </summary>
        public virtual int? Enable
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
        /// starttime
        /// </summary>
        public virtual DateTime? starttime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// endtime
        /// </summary>
        public virtual DateTime? endtime
        {
            get; 
            set; 
        } 
         
           
                public JY_QuestionType()
        {
        
        }
   
    }
    
}
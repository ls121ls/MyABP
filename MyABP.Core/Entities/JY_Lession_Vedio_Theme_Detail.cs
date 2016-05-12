using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //JY_Lession_Vedio_Theme_Detail
        public class JY_Lession_Vedio_Theme_Detail:Entity
    {
    
          /// <summary>
        /// AutoID
        /// </summary>
        public virtual int AutoID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Lession_ID
        /// </summary>
        public virtual int? Lession_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Lession_Img
        /// </summary>
        public virtual string Lession_Img
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Lession_MMS_ID
        /// </summary>
        public virtual int? Lession_MMS_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Theme_ID
        /// </summary>
        public virtual int? Theme_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Theme_Title
        /// </summary>
        public virtual string Theme_Title
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
         
           
                public JY_Lession_Vedio_Theme_Detail()
        {
        
        }
   
    }
    
}
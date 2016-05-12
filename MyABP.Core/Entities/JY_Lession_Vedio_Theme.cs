using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //JY_Lession_Vedio_Theme
        public class JY_Lession_Vedio_Theme:Entity
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
        /// Lession_ThemeCut
        /// </summary>
        public virtual string Lession_ThemeCut
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Lession_TimeCut
        /// </summary>
        public virtual string Lession_TimeCut
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
         
           
                public JY_Lession_Vedio_Theme()
        {
        
        }
   
    }
    
}
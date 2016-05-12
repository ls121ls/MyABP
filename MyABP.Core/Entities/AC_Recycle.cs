using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AC_Recycle
        public class AC_Recycle:Entity
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
        /// MainID
        /// </summary>
        public virtual int MainID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// HistoryID
        /// </summary>
        public virtual int HistoryID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Type
        /// </summary>
        public virtual int? Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Reason
        /// </summary>
        public virtual string Reason
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// objContent
        /// </summary>
        public virtual string objContent
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OperatorNM
        /// </summary>
        public virtual int OperatorNM
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
        /// State
        /// </summary>
        public virtual int? State
        {
            get; 
            set; 
        } 
         
           
                public AC_Recycle()
        {
        
        }
   
    }
    
}
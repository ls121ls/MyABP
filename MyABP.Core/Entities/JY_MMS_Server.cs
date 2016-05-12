using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //课件播放地址表
        public class JY_MMS_Server:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual int ID
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
        /// 播放地址
        /// </summary>
        public virtual string Url
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Rule
        /// </summary>
        public virtual string Rule
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Enabled
        /// </summary>
        public virtual int Enabled
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TextField
        /// </summary>
        public virtual string TextField
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// First
        /// </summary>
        public virtual int? First
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
         
           
                public JY_MMS_Server()
        {
        
        }
   
    }
    
}
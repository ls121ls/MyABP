using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //直播标识对应表
        public class Live_Designator:Entity
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
        /// 直播ID
        /// </summary>
        public virtual int LiveID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 标识ID
        /// </summary>
        public virtual int DesignatorID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 权重
        /// </summary>
        public virtual int weight
        {
            get; 
            set; 
        } 
         
           
                public Live_Designator()
        {
        
        }
   
    }
    
}
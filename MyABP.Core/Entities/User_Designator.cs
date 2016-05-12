using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //用户标签对应表
        public class User_Designator:Entity
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
        /// 标识ID
        /// </summary>
        public virtual int DesignatorID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户编号
        /// </summary>
        public virtual int UserNM
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
         
           
                public User_Designator()
        {
        
        }
   
    }
    
}
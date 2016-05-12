using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //课件频道对应表
        public class JY_Channellesson:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual int id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 频道编号
        /// </summary>
        public virtual int? Channelid
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课程编号
        /// </summary>
        public virtual int? lessionid
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// content
        /// </summary>
        public virtual string content
        {
            get; 
            set; 
        } 
         
           
                public JY_Channellesson()
        {
        
        }
   
    }
    
}
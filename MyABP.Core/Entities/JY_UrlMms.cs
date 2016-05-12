using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //课程播放地址表
        public class JY_UrlMms:Entity
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
        /// 课程编号
        /// </summary>
        public virtual string UID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 播放地址
        /// </summary>
        public virtual string Mms
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
        /// 节点数
        /// </summary>
        public virtual string Note
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 播放地址描述
        /// </summary>
        public virtual string title
        {
            get; 
            set; 
        } 
         
           
                public JY_UrlMms()
        {
        
        }
   
    }
    
}
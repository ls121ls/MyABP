using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //通告公告指定表
        public class JY_NoticeUsers:Entity
    {
    
          /// <summary>
        /// 通知公告编号
        /// </summary>
        public virtual int NoticeId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户编号
        /// </summary>
        public virtual decimal UserNm
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
        /// 是否已读
        /// </summary>
        public virtual bool Readed
        {
            get; 
            set; 
        } 
         
           
                public JY_NoticeUsers()
        {
        
        }
   
    }
    
}
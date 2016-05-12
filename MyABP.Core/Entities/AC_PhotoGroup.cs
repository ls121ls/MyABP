using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AC_PhotoGroup
        public class AC_PhotoGroup:Entity
    {
    
          /// <summary>
        /// 标示
        /// </summary>
        public virtual int ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建用户
        /// </summary>
        public virtual int CreateUserNM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 标题
        /// </summary>
        public virtual string Title
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 封面路径
        /// </summary>
        public virtual string ImgPath
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 状态(0,开放,1.密码访问,2.自己才能看到)
        /// </summary>
        public virtual int? Status
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string RMK
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 密码
        /// </summary>
        public virtual string PassWord
        {
            get; 
            set; 
        } 
         
           
                public AC_PhotoGroup()
        {
        
        }
   
    }
    
}
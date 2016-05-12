using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //课件频道表
        public class JY_Channel:Entity
    {
    
          /// <summary>
        /// 课件频道编号
        /// </summary>
        public virtual int ChannelID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SchoolName
        /// </summary>
        public virtual string SchoolName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 课件频道名称
        /// </summary>
        public virtual string ChannelName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ChannelShortName
        /// </summary>
        public virtual string ChannelShortName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ChannelItemUnit
        /// </summary>
        public virtual string ChannelItemUnit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ReadMe
        /// </summary>
        public virtual string ReadMe
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ChannelPicUrl
        /// </summary>
        public virtual string ChannelPicUrl
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OrderID
        /// </summary>
        public virtual int? OrderID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OpenType
        /// </summary>
        public virtual int? OpenType
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ChannelType
        /// </summary>
        public virtual int? ChannelType
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LinkUrl
        /// </summary>
        public virtual string LinkUrl
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ChannelDir
        /// </summary>
        public virtual string ChannelDir
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ModuleType
        /// </summary>
        public virtual int? ModuleType
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Disabled
        /// </summary>
        public virtual int Disabled
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 频道父级编号
        /// </summary>
        public virtual int? parentid
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
         
           
                public JY_Channel()
        {
        
        }
   
    }
    
}
using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //模板表
        public class T_TemplateStyle:Entity
    {
    
          /// <summary>
        /// 自增标示列
        /// </summary>
        public virtual int ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 模板名称（T：Template）
        /// </summary>
        public virtual string T_Title
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 模板作者
        /// </summary>
        public virtual string T_Author
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 模板样图
        /// </summary>
        public virtual string T_SamplePlot
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 样式文件（实例:NeiMWidgetsStle.css...）
        /// </summary>
        public virtual string T_StyleName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime? T_CreateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 模板备注
        /// </summary>
        public virtual string T_Remark
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// T_temp1
        /// </summary>
        public virtual string T_temp1
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// T_temp2
        /// </summary>
        public virtual string T_temp2
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// T_temp3
        /// </summary>
        public virtual string T_temp3
        {
            get; 
            set; 
        } 
         
           
                public T_TemplateStyle()
        {
        
        }
   
    }
    
}
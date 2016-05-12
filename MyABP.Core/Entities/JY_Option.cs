using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //问题选项
        public class JY_Option:Entity
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
        /// 问题编号
        /// </summary>
        public virtual int? questionId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 选项名称
        /// </summary>
        public virtual string Title
        {
            get; 
            set; 
        } 
         
           
                public JY_Option()
        {
        
        }
   
    }
    
}
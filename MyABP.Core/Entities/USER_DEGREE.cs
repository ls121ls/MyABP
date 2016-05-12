using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //学历表
        public class USER_DEGREE:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual int Degree_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 学历名称
        /// </summary>
        public virtual string Degree_name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// per_Degree_id
        /// </summary>
        public virtual int? per_Degree_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Start_time
        /// </summary>
        public virtual DateTime? Start_time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// User_id
        /// </summary>
        public virtual string User_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Finish_type
        /// </summary>
        public virtual string Finish_type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Special
        /// </summary>
        public virtual string Special
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Graduate_School
        /// </summary>
        public virtual string Graduate_School
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Graduate_Number
        /// </summary>
        public virtual string Graduate_Number
        {
            get; 
            set; 
        } 
         
           
                public USER_DEGREE()
        {
        
        }
   
    }
    
}
using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //T_TrainClassExam
        public class T_TrainClassExam:Entity
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
        /// ExamID
        /// </summary>
        public virtual int? ExamID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TrainID
        /// </summary>
        public virtual int? TrainID
        {
            get; 
            set; 
        } 
         
           
                public T_TrainClassExam()
        {
        
        }
   
    }
    
}
using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //USER_ONLINE_TIME_HISTORY
        public class USER_ONLINE_TIME_HISTORY:Entity
    {
    
          /// <summary>
        /// u_id
        /// </summary>
        public virtual decimal u_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// login_time
        /// </summary>
        public virtual DateTime? login_time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// exit_time
        /// </summary>
        public virtual DateTime? exit_time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Length_time
        /// </summary>
        public virtual decimal? Length_time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// user_id
        /// </summary>
        public virtual string user_id
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// user_state
        /// </summary>
        public virtual string user_state
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// last_time
        /// </summary>
        public virtual DateTime? last_time
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// user_identity
        /// </summary>
        public virtual string user_identity
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
         
           
        /// <summary>
        /// user_ip
        /// </summary>
        public virtual string user_ip
        {
            get; 
            set; 
        } 
         
           
                public USER_ONLINE_TIME_HISTORY()
        {
        
        }
   
    }
    
}
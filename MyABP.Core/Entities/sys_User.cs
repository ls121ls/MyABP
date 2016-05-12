using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //sys_User
        public class sys_User:Entity
    {
    
          /// <summary>
        /// UserID
        /// </summary>
        public virtual int UserID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_LoginName
        /// </summary>
        public virtual string U_LoginName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_Password
        /// </summary>
        public virtual string U_Password
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_CName
        /// </summary>
        public virtual string U_CName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_EName
        /// </summary>
        public virtual string U_EName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_GroupID
        /// </summary>
        public virtual int U_GroupID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_Email
        /// </summary>
        public virtual string U_Email
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_Type
        /// </summary>
        public virtual int U_Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_Status
        /// </summary>
        public virtual int U_Status
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_Licence
        /// </summary>
        public virtual string U_Licence
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_Mac
        /// </summary>
        public virtual string U_Mac
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_Remark
        /// </summary>
        public virtual string U_Remark
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_IDCard
        /// </summary>
        public virtual string U_IDCard
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_Sex
        /// </summary>
        public virtual int? U_Sex
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_BirthDay
        /// </summary>
        public virtual DateTime? U_BirthDay
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_MobileNo
        /// </summary>
        public virtual string U_MobileNo
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_UserNO
        /// </summary>
        public virtual string U_UserNO
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_WorkStartDate
        /// </summary>
        public virtual DateTime? U_WorkStartDate
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_WorkEndDate
        /// </summary>
        public virtual DateTime? U_WorkEndDate
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_CompanyMail
        /// </summary>
        public virtual string U_CompanyMail
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_Title
        /// </summary>
        public virtual int? U_Title
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_Extension
        /// </summary>
        public virtual string U_Extension
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_HomeTel
        /// </summary>
        public virtual string U_HomeTel
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_PhotoUrl
        /// </summary>
        public virtual string U_PhotoUrl
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_DateTime
        /// </summary>
        public virtual DateTime? U_DateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_LastIP
        /// </summary>
        public virtual string U_LastIP
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_LastDateTime
        /// </summary>
        public virtual DateTime? U_LastDateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// U_ExtendField
        /// </summary>
        public virtual string U_ExtendField
        {
            get; 
            set; 
        } 
         
           
                public sys_User()
        {
        
        }
   
    }
    
}
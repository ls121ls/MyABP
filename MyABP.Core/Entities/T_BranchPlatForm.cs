using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //平台表
        public class T_BranchPlatForm:Entity
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
        /// 附属平台名称
        /// </summary>
        public virtual string BP_PlatName_TXT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 附属平台域名
        /// </summary>
        public virtual string BP_PlatDomain_TXT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 开通时间
        /// </summary>
        public virtual DateTime? BP_DeployTime_DT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 添加人
        /// </summary>
        public virtual string BP_DeployAuthor_TXT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 平台标志图
        /// </summary>
        public virtual string BP_PlatSign_TXT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 平台描述图
        /// </summary>
        public virtual string BP_PlatDesPic_TXT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// BP_IPaddress_TXT
        /// </summary>
        public virtual string BP_IPaddress_TXT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 是否启用平台
        /// </summary>
        public virtual int? BP_PlatEnable_NBR
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string BP_PlatRemark_TXT
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 内页版式
        /// </summary>
        public virtual string ExtendField1
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ExtendField2
        /// </summary>
        public virtual string ExtendField2
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ExtendField3
        /// </summary>
        public virtual string ExtendField3
        {
            get; 
            set; 
        } 
         
           
                public T_BranchPlatForm()
        {
        
        }
   
    }
    
}
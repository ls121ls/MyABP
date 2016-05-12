using System;
using Abp.Domain.Entities;

namespace MyABP.Entities{
         //AICC节点表
        public class AICC_J_SCORE_STATUS:Entity
    {
    
          /// <summary>
        /// 编号
        /// </summary>
        public virtual decimal J_SCORE_STATUS_NUM
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 公司课程编号
        /// </summary>
        public virtual string COURSE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 用户名
        /// </summary>
        public virtual string STUDENT_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 部分编号(如果一门课有多个部分),和JY_UrlMMS的ID关联
        /// </summary>
        public virtual string OBJ_OBJECTIVE_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OBJ_SCORE
        /// </summary>
        public virtual string OBJ_SCORE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 节点状态(S,I,C)
        /// </summary>
        public virtual string OBJ_STATUS
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 节点创建日期
        /// </summary>
        public virtual DateTime? OBJ_DATE
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SESSION_ID
        /// </summary>
        public virtual string SESSION_ID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 流媒体课件部分数,AICC暂停秒数
        /// </summary>
        public virtual int? uidcount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 流媒体分钟数,AICC节点最后播放点
        /// </summary>
        public virtual int? timems
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// 流媒体视频长度,AICC节点长度
        /// </summary>
        public virtual int? length
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// lessionState
        /// </summary>
        public virtual string lessionState
        {
            get; 
            set; 
        } 
         
           
                public AICC_J_SCORE_STATUS()
        {
        
        }
   
    }
    
}
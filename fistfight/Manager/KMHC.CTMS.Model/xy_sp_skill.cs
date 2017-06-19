/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2017-06-15                                         创建 
 *  
 */
 
using System;

namespace Project.Model
{
    public class V_xy_sp_skill
    {      
    	    			         	/// <summary>
		        /// SkillID
		        /// </summary>
		     		        		public string SkillID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SkillName
		        /// </summary>
		     		        		public string SkillName  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SkillDescription
		        /// </summary>
		     		        		public string SkillDescription  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SkillPathPrompt
		        /// </summary>
		     		        		public string SkillPathPrompt  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SkillType
		        /// </summary>
		     		        		public string SkillType  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SkillGainValue
		        /// </summary>
		     		        		public Nullable<decimal> SkillGainValue  { get; set; }
	        		        	
         		         	/// <summary>
		        /// ExpendType
		        /// </summary>
		     		        		public string ExpendType  { get; set; }
	        		        	
         		         	/// <summary>
		        /// ExpendValue
		        /// </summary>
		     		        		public Nullable<decimal> ExpendValue  { get; set; }
	        		        	
         		         	/// <summary>
		        /// isGroupinjury
		        /// </summary>
		     		        		public Nullable<decimal> isGroupinjury  { get; set; }
	        		        	
         		         	/// <summary>
		        /// injuryCount
		        /// </summary>
		     		        		public Nullable<decimal> injuryCount  { get; set; }
	        		        	
         		         	/// <summary>
		        /// NeedLevel
		        /// </summary>
		     		        		public Nullable<decimal> NeedLevel  { get; set; }
	        		        	
         	    	    }
}
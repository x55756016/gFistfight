/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2017-05-31                                         创建 
 *  
 */
 
using System;

namespace Project.Model
{
    public class V_xy_sp_taskoption
    {      
    	    			         	/// <summary>
		        /// OptionID
		        /// </summary>
		     		        		public string OptionID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// OptionName
		        /// </summary>
		     		        		public string OptionName  { get; set; }
	        		        	
         		         	/// <summary>
		        /// OptionDesc
		        /// </summary>
		     		        		public string OptionDesc  { get; set; }
	        		        	
         		         	/// <summary>
		        /// IsCorrect
		        /// </summary>
		     		        		public Nullable<decimal> IsCorrect  { get; set; }
	        		        	
         		         	/// <summary>
		        /// NextTaskID
		        /// </summary>
		     		        		public string NextTaskID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// PreviousTaskID
		        /// </summary>
		     		        		public string PreviousTaskID  { get; set; }
	        		        	
         	    	    }
}
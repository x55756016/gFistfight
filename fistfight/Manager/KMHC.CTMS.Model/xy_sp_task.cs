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
    public class V_xy_sp_task
    {      
    	    			         	/// <summary>
		        /// chapterID
		        /// </summary>
		     		        		public string chapterID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// TaskID
		        /// </summary>
		     		        		public string TaskID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// TaskName
		        /// </summary>
		     		        		public string TaskName  { get; set; }
	        		        	
         		         	/// <summary>
		        /// TaskDescript
		        /// </summary>
		     		        		public string TaskDescript  { get; set; }
	        		        	
         		         	/// <summary>
		        /// NpcName
		        /// </summary>
		     		        		public string NpcName  { get; set; }
	        		        	
         		         	/// <summary>
		        /// IsBattleTask
		        /// </summary>
		     		        		public Nullable<decimal> IsBattleTask  { get; set; }
	        		        	
         	    	    }
}
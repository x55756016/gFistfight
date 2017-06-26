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
    public class V_xy_sp_spiritskill
    {      
    	    			         	/// <summary>
		        /// SpiritSkillID
		        /// </summary>
		     		        		public string SpiritSkillID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SpiritID
		        /// </summary>
		     		        		public string SpiritID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SkillID
		        /// </summary>
		     		        		public string SkillID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// IsReady
		        /// </summary>
		     		        		public Nullable<decimal> IsReady  { get; set; }

                                    public V_xy_sp_skill skill { get; set; }
	        		        	
         	    	    }
}
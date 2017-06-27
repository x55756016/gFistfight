﻿/*
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
    public class V_xy_sp_taskspirit
    {      
    	    			         	/// <summary>
		        /// UserSpiritID
		        /// </summary>
		     		        		public string UserSpiritID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// UserId
		        /// </summary>
                                    public string TaskID { get; set; }
	        		        	
         		         	/// <summary>
		        /// SpiritID
		        /// </summary>
		     		        		public string SpiritID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// isBoos
		        /// </summary>
		     		        		public Nullable<decimal> isBoos  { get; set; }


                                    public V_xy_sp_spirit spirit { get; set; }
	        		        	
         	    	    }
}
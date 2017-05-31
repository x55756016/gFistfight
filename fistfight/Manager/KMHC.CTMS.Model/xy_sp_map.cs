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
    public class V_xy_sp_map
    {      
    	    			         	/// <summary>
		        /// AddrID
		        /// </summary>
		     		        		public string AddrID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// AddrName
		        /// </summary>
		     		        		public string AddrName  { get; set; }
	        		        	
         		         	/// <summary>
		        /// AddrDescript
		        /// </summary>
		     		        		public string AddrDescript  { get; set; }
	        		        	
         		         	/// <summary>
		        /// AddrX
		        /// </summary>
		     		        		public Nullable<decimal> AddrX  { get; set; }
	        		        	
         		         	/// <summary>
		        /// AddrY
		        /// </summary>
		     		        		public Nullable<decimal> AddrY  { get; set; }
	        		        	
         		         	/// <summary>
		        /// FatherAddrID
		        /// </summary>
		     		        		public string FatherAddrID  { get; set; }
	        		        	
         	    	    }
}
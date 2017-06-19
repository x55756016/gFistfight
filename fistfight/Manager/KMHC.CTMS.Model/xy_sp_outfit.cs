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
    public class V_xy_sp_outfit
    {      
    	    			         	/// <summary>
		        /// OutfitID
		        /// </summary>
		     		        		public string OutfitID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// EquipmentName
		        /// </summary>
		     		        		public string EquipmentName  { get; set; }
	        		        	
         		         	/// <summary>
		        /// NeedLevel
		        /// </summary>
		     		        		public Nullable<decimal> NeedLevel  { get; set; }
	        		        	
         		         	/// <summary>
		        /// Price
		        /// </summary>
		     		        		public Nullable<decimal> Price  { get; set; }
	        		        	
         	    	    }
}
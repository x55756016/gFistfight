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
    public class V_xy_sp_equipment
    {      
    	    			         	/// <summary>
		        /// EquipmentID
		        /// </summary>
		     		        		public string EquipmentID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// EquipmentName
		        /// </summary>
		     		        		public string EquipmentName  { get; set; }
	        		        	
         		         	/// <summary>
		        /// EquipmentType
		        /// </summary>
		     		        		public Nullable<decimal> EquipmentType  { get; set; }
	        		        	
         		         	/// <summary>
		        /// gainType
		        /// </summary>
		     		        		public Nullable<decimal> gainType  { get; set; }
	        		        	
         		         	/// <summary>
		        /// gainValue
		        /// </summary>
		     		        		public Nullable<decimal> gainValue  { get; set; }
	        		        	
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
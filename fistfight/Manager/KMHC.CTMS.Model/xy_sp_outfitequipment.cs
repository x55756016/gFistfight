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
    public class V_xy_sp_outfitequipment
    {      
    	    			         	/// <summary>
		        /// OutfitEquipmentID
		        /// </summary>
		     		        		public string OutfitEquipmentID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// OutfitID
		        /// </summary>
		     		        		public string OutfitID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// EquipmentID
		        /// </summary>
		     		        		public string EquipmentID  { get; set; }
	        		        	
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
	        		        	
         	    	    }
}
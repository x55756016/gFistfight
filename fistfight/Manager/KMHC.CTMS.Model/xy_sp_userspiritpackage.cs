/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2017-06-27                                         创建 
 *  
 */
 
using System;

namespace Project.Model
{
    public class V_xy_sp_userspiritpackage
    {      
    	    			         	/// <summary>
		        /// SpiritPackageID
		        /// </summary>
		     		        		public string SpiritPackageID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// UserSpiritID
		        /// </summary>
		     		        		public string UserSpiritID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// EquipmentID
		        /// </summary>
		     		        		public string EquipmentID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// LostRate
		        /// </summary>
		     		        		public Nullable<decimal> LostRate  { get; set; }
	        		        	
         	    	    }
}
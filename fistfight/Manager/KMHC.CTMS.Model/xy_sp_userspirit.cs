/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2017-06-15                                         创建 
 *  
 */
 
using System;
using System.Collections.Generic;

namespace Project.Model
{
    [Serializable]
    public class V_xy_sp_userspirit
    {     
 
        public V_xy_sp_userspirit()
        {
            spEquipmentList = new List<V_xy_sp_spiritequipment>();
            spSkillList = new List<V_xy_sp_spiritskill>();
            packageList = new List<V_xy_sp_userspiritpackage>();
        }
    	    			         	/// <summary>
		        /// UserSpiritID
		        /// </summary>
		     		        		public string UserSpiritID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// UserId
		        /// </summary>
		     		        		public string UserId  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SpiritID
		        /// </summary>
		     		        		public string SpiritID  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SpiritName
		        /// </summary>
		     		        		public string SpiritName  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SpiritLifeMax
		        /// </summary>
		     		        		public Nullable<decimal> SpiritLifeMax  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SpiritMagicMax
		        /// </summary>
		     		        		public Nullable<decimal> SpiritMagicMax  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SpiritLife
		        /// </summary>
		     		        		public Nullable<decimal> SpiritLife  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SpiritMagic
		        /// </summary>
		     		        		public Nullable<decimal> SpiritMagic  { get; set; }
	        		        	
         		         	/// <summary>
		        /// PhysicalResistance
		        /// </summary>
		     		        		public Nullable<decimal> PhysicalResistance  { get; set; }
	        		        	
         		         	/// <summary>
		        /// MagicResistance
		        /// </summary>
		     		        		public Nullable<decimal> MagicResistance  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SpiritLevel
		        /// </summary>
		     		        		public Nullable<decimal> SpiritLevel  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SpiritExperience
		        /// </summary>
		     		        		public Nullable<decimal> SpiritExperience  { get; set; }
	        		        	
         		         	/// <summary>
		        /// SpiritMoney
		        /// </summary>
		     		        		public Nullable<decimal> SpiritMoney  { get; set; }
	        		        	
         		         	/// <summary>
		        /// PhysicalHarm
		        /// </summary>
		     		        		public Nullable<decimal> PhysicalHarm  { get; set; }
	        		        	
         		         	/// <summary>
		        /// MagicHarm
		        /// </summary>
		     		        		public Nullable<decimal> MagicHarm  { get; set; }
	        		        	
         		         	/// <summary>
		        /// Spiritspeed
		        /// </summary>
		     		        		public Nullable<decimal> Spiritspeed  { get; set; }
	        		        	
         		         	/// <summary>
		        /// CurrentTaskID
		        /// </summary>
		     		        		public string CurrentTaskID  { get; set; } 
        
        /// <summary>
                                    /// Maxpackage
		        /// </summary>
                                    public Nullable<decimal> Maxpackage { get; set; }
                                    //精灵背包
                                    public List<V_xy_sp_userspiritpackage> packageList { get; set; }

                                    public List<V_xy_sp_spiritequipment> spEquipmentList { get; set; }

                                    public List<V_xy_sp_spiritskill> spSkillList { get; set; }
	        		        	
         	    	    }
}
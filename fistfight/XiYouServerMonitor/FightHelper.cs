using Project.BLL;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiYouServerMonitor
{
  public static  class FightHelper
    {

      /// <summary>
      /// 战斗并返回所有怪物状态
      /// </summary>
      /// <param name="FighterFrom">用户精灵</param>
      /// <param name="skill">技能</param>
      /// <param name="FighterToList"></param>
      /// <returns></returns>
      public static List<V_xy_sp_spirit> FightBySkill(V_xy_sp_userspirit FighterFrom, V_xy_sp_skill skill, List<V_xy_sp_spirit> FighterToList,ref string batmsgAll)
      {
          List<V_xy_sp_spirit> FighterToResult = new List<V_xy_sp_spirit>();
          FighterFrom.SpiritMagic = FighterFrom.SpiritMagic - skill.ExpendValue;
           
               int maxInjuryCount = 0;
               foreach (V_xy_sp_spirit spirit in FighterToList)
               {
                   if (spirit.SpiritLife <= 0) continue;//生命值低于0跳过
                   if (skill.isGroupinjury == 1 && maxInjuryCount == FighterToList.Count)
                   {
                       //如果是群攻并且攻击次数已到最大次数，不攻击
                       FighterToResult.Add(spirit);
                       continue;
                   }else if(maxInjuryCount==1)
                   {
                       //如果非群攻，不攻击
                       FighterToResult.Add(spirit);
                       continue;
                   }
                   string batmsg=string.Empty;
                   SkillInjury(FighterFrom, skill, spirit, ref batmsg);
                   batmsgAll = batmsgAll + System.Environment.NewLine + batmsg;
                   maxInjuryCount++;
                   FighterToResult.Add(spirit);
               }
           
           return FighterToResult;


      }

      private static V_xy_sp_spirit SkillInjury(V_xy_sp_userspirit FighterFrom, V_xy_sp_skill skill, V_xy_sp_spirit FighterTo,ref string batmsg)
      {
          V_xy_sp_spirit Fightersult = new V_xy_sp_spirit();
          switch (skill.SkillType)
          {
              case "1"://物理伤害   
                      //我方增加经验
                  updateEnemy(FighterFrom, FighterTo, skill, ref batmsg);
                  break;
              default:
                  updateEnemy(FighterFrom, FighterTo, skill, ref batmsg);
                  break;
          }
          Fightersult = FighterTo;
          return Fightersult;
      }

      /// <summary>
      /// 我方对怪物的伤害杀死的情况
      /// </summary>
      /// <param name="FighterFrom"></param>
      /// <param name="FighterTo"></param>
      private static void updateEnemy(V_xy_sp_userspirit FighterFrom, V_xy_sp_spirit FighterTo, V_xy_sp_skill skill, ref string batmsg)
      {
          var LifeLeftValue = FighterTo.SpiritLife - skill.SkillGainValue;

          batmsg ="\""+FighterFrom.SpiritName + "\"使用\"" + skill.SkillName + "\"攻击\"" + FighterTo.SpiritName + "\"造成\"" + skill.SkillGainValue + "\"点物理伤害";
          if (LifeLeftValue <= 0)//敌人已死亡
          {
              //更新等级和经验
              xy_sp_userspiritBLL uspBll = new xy_sp_userspiritBLL();
              decimal Experience = FighterTo.SpiritExperience.Value;
              FighterFrom.SpiritExperience += Experience;
              //等级
              if (FighterFrom.SpiritExperience > LevelExperience(FighterFrom.SpiritLevel.Value))
              {
                  FighterFrom.SpiritLevel = FighterFrom.SpiritLevel + 1;
                  FighterFrom.SpiritExperience = FighterFrom.SpiritExperience - LevelExperience(FighterFrom.SpiritLevel.Value);
              }
              uspBll.Edit(FighterFrom);
              //我方获取敌方装备
              xy_sp_userspiritpackageBLL spBll = new xy_sp_userspiritpackageBLL();
              foreach (var item in FighterTo.spiritEquipmentList)
              {
                  V_xy_sp_userspiritpackage packageItem = new V_xy_sp_userspiritpackage();
                  packageItem.UserSpiritID = FighterFrom.UserSpiritID;
                  packageItem.EquipmentID = item.EquipmentID;
                  spBll.Add(packageItem);
              }
          }
          else
          {
              //更新怪物生命值
              FighterTo.SpiritLife = LifeLeftValue;
          }
      }

      private static decimal LevelExperience(decimal n)
      {
          decimal result = (n + 1) * 1000;
          return result;
      }  
    }
}

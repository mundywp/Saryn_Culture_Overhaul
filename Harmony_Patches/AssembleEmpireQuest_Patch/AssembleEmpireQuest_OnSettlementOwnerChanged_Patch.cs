using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Settlements;
using static StoryMode.Quests.SecondPhase.AssembleEmpireQuestBehavior;

namespace Saryn_Culture_Overhaul
{
    [HarmonyPatch(typeof(AssembleEmpireQuest), "OnSettlementOwnerChanged")]
    public static class AssembleEmpireQuest_OnSettlementOwnerChanged_Patch
    {
        public static bool Prefix(Settlement settlement, bool openToClaim, Hero newOwner, Hero oldOwner, Hero capturerHero, ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail detail, int ____ownedByPlayerImperialTowns, JournalLog ____numberOfCapturedSettlementsLog, int ____imperialCultureTowns)
        {
            if (settlement.IsTown && settlement.Culture.StringId.Contains("empire"))
            {
                if (settlement.OwnerClan.Kingdom == Clan.PlayerClan.Kingdom && oldOwner.Clan.Kingdom != Clan.PlayerClan.Kingdom)
                {
                    ____ownedByPlayerImperialTowns++;
                }
                if (oldOwner.Clan.Kingdom == Clan.PlayerClan.Kingdom && newOwner.Clan.Kingdom != Clan.PlayerClan.Kingdom)
                {
                    ____ownedByPlayerImperialTowns--;
                }
                ____numberOfCapturedSettlementsLog.UpdateCurrentProgress((int)Clamp((float)____ownedByPlayerImperialTowns, 0f, (float)____imperialCultureTowns));
            }

            return false;
        }

        public static float Clamp(float value, float minValue, float maxValue)
        {
            if (value < minValue)
            {
                return minValue;
            }
            if (value > maxValue)
            {
                return maxValue;
            }
            return value;
        }
    }
}

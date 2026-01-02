using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using static StoryMode.Quests.SecondPhase.AssembleEmpireQuestBehavior;

namespace Saryn_Culture_Overhaul
{
    // Type warning here is due to the fact that this method is a private one
    [HarmonyPatch(typeof(AssembleEmpireQuest), "CacheSettlementCounts")]
    public static class AssembleEmpireQuest_CacheSettlementCounts_Patch
    {
        public static bool Prefix(int ____ownedByPlayerImperialTowns, int ____imperialCultureTowns)
        {
            ____imperialCultureTowns = 0;
            ____ownedByPlayerImperialTowns = 0;
            foreach (Settlement settlement in Settlement.All)
            {
                if (settlement.IsTown && settlement.Culture.StringId.Contains("empire"))
                {
                    ____imperialCultureTowns++;
                    if (settlement.OwnerClan.Kingdom == Clan.PlayerClan.Kingdom)
                    {
                        ____ownedByPlayerImperialTowns++;
                    }
                }
            }
            return false;
        }
    }
}

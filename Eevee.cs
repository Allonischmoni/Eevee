using MelonLoader;
using BTD_Mod_Helper;
using Eevee;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using BTD_Mod_Helper.Api.Display;
using NodeLoader;

[assembly: MelonInfo(typeof(Eevee.Main), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Eevee
{
    public class Main : BloonsTD6Mod
    {
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("Eevee loaded!");
        }
    }
    public class Eevee : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Magic;
        public override string Name => "Eevee";
        public override string BaseTower => TowerType.Druid;
        public override int Cost => 400;

        public override int TopPathUpgrades => 5;
        public override int MiddlePathUpgrades => 5;
        public override int BottomPathUpgrades => 5;
        public override string Description => "A Pokemon-tower with several Evolutions";

        public override string DisplayName => "Eevee";

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.range += 10;
            var attackModel = towerModel.GetAttackModel();
            attackModel.range += 10;

            var projectile = attackModel.weapons[0].projectile;
            projectile.pierce += 2;
            towerModel.ApplyDisplay<EeveeDisplay>();
        }
        
    }
    public class EeveeDisplay : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            NodeLoader.NodeLoader.LoadNode(node, "Eevee", mod);
        }
    }
}


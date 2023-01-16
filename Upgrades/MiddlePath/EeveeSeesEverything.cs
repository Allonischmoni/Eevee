using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Utils;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;

namespace Eevee.Upgrades.MiddlePath
{
    public class EeveeSeesEverything : ModUpgrade <Eevee>
    {
        public override int Path => MIDDLE;
        public override int Tier => 1;
        public override int Cost => 250;
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("SniperMonkey-010").GetUpgrade(MIDDLE, 1).icon;
        public override string Description => "Eevee can see camo";
        public override int Priority => -1;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
        }
    }
}

using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;

namespace Eevee.Upgrades.MiddlePath
{
    public class MoreFasterEevee : ModUpgrade<Eevee>
    {
        public override int Path => BOTTOM;
        public override int Tier => 2;
        public override int Cost => 500;
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("DartMonkey-020").GetUpgrade(MIDDLE , 2).icon;
        public override string Description => "Even more faster";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.7f;
        }
    }
}

using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Utils;
using Il2CppAssets.Scripts.Unity;

namespace Eevee.Upgrades.MiddlePath
{
    public class FasterEevee : ModUpgrade<Eevee>
    {
        public override int Path => BOTTOM;
        public override int Tier => 1;
        public override int Cost => 320;
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("DartMonkey-010").GetUpgrade(MIDDLE, 1).icon;
        public override string Description => "Faster attack speed";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.66f;
        }
    }
}

using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Utils;
using Il2CppAssets.Scripts.Unity;

namespace Eevee.Upgrades.TopPath
{
    public class PiercedPins : ModUpgrade<Eevee>
    {
        public override int Path => TOP;
        public override int Tier => 1;
        public override int Cost => 400;
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("DartMonkey-100").GetUpgrade(TOP, 1).icon;
        public override string Description => "Plus one Pierce";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var projectileModel = towerModel.GetAttackModel().GetDescendant<ProjectileModel>();
            projectileModel.pierce += 1;
        }
    }
}

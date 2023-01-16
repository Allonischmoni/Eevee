using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;

namespace Eevee.Upgrades.MiddlePath
{
    public class CoolGlaceon : ModUpgrade<Eevee>
    {
        public override int Path => BOTTOM;
        public override int Tier => 4;
        public override int Cost => 2500;
        public override string Portrait => "GlaceonPortrait";
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("IceMonkey-004").GetUpgrade(BOTTOM, 4).icon;
        public override string Description => "More damage and pierce";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var projectileModel = towerModel.GetAttackModel().GetDescendant<ProjectileModel>();
            projectileModel.GetDamageModel().damage += 2;
            projectileModel.pierce += 2;
            var attackModel = towerModel.GetAttackModel();
            attackModel.AddBehavior(Game.instance.model.GetTowerFromId("IceMonkey-004").GetAttackModel().weapons[0].Duplicate());
        }
    }
}

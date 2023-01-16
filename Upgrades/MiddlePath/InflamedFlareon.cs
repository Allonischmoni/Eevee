using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;
using Il2CppAssets.Scripts.Models.Towers.Filters;

namespace Eevee.Upgrades.MiddlePath
{
    public class InflamedFlareon : ModUpgrade<Eevee>
    {
        public override int Path => MIDDLE;
        public override int Tier => 4;
        public override int Cost => 2500;
        public override string Portrait => "FlareonPortrait2";
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("WizardMonkey-030").GetUpgrade(MIDDLE, 3).icon;
        public override string Description => "More damage and pierce";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var projectileModel = attackModel.GetDescendant<ProjectileModel>();
            projectileModel.GetDamageModel().damage += 8;
            projectileModel.pierce += 5;
            attackModel.weapons[0].projectile = Game.instance.model.GetTowerFromId("Gwendolin 20").GetAttackModel().weapons[0].projectile.Duplicate();
            attackModel.weapons[0].projectile.SetHitCamo(true);
        }
    }
}

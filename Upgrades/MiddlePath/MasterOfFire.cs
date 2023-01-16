using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;

namespace Eevee.Upgrades.MiddlePath
{
    public class MasterOfFire : ModUpgrade<Eevee>
    {
        public override int Path => MIDDLE;
        public override int Tier => 5;
        public override int Cost => 42000;
        public override string Portrait => "FlareonPortrait3";
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("TackShooter-500").GetUpgrade(TOP, 5).icon;
        public override string Description => "Increased range, pierce, damage and attack speed";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var projectileModel = attackModel.GetDescendant<ProjectileModel>();
            towerModel.range += 20;
            attackModel.range += 20;
            projectileModel.pierce += 6;
            projectileModel.GetDamageModel().damage += 40;
            towerModel.GetWeapon().rate *= 0.1f;
        }
    }
}

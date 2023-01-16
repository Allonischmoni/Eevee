using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Utils;

namespace Eevee.Upgrades.TopPath
{
    public class MasterOfElectricity : ModUpgrade <Eevee>
    {
        public override int Path => TOP;
        public override int Tier => 5;
        public override int Cost => 35000;
        public override string Portrait => "BlitzaPortrait2";
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("EngineerMonkey-050").GetUpgrade(MIDDLE, 5).icon;
        public override string Description => "More damage, pierce and range";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var projectileModel = towerModel.GetAttackModel().GetDescendant<ProjectileModel>();
            var attackModel = towerModel.GetAttackModel();
            towerModel.range += 20;
            attackModel.range += 20;
            attackModel.weapons[0].projectile.GetDamageModel().damage += 4;
            attackModel.weapons[0].projectile.GetDamageModel().damage += 4;
            projectileModel.pierce += 8;
        }
    }
}

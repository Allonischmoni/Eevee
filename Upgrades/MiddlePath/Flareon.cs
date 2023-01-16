using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;
using Il2CppAssets.Scripts.Models.Towers.Filters;

namespace Eevee.Upgrades.MiddlePath
{
    public class Flareon : ModUpgrade<Eevee>
    {
        public override int Path => MIDDLE;
        public override int Tier => 3;
        public override int Cost => 2500;
        public override string Portrait => "FlareonPortrait";
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("WizardMonkey-010").GetUpgrade(MIDDLE, 1).icon;
        public override string Description => "Evolving Eevee to Flareon and increases the attack speed and pierce";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel(); 
            var projectileModel = attackModel.GetDescendant<ProjectileModel>();
            projectileModel.pierce += 2;
            attackModel.weapons[0].projectile = Game.instance.model.GetTowerFromId("Gwendolin 15").GetAttackModel().weapons[0].projectile.Duplicate();
            towerModel.GetWeapon().rate *= 0.5f;
            attackModel.weapons[0].projectile.SetHitCamo(true);
        }
    }
}

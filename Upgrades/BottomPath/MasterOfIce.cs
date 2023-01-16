using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;

namespace Eevee.Upgrades.MiddlePath
{
    public class MasterOfIce : ModUpgrade<Eevee>
    {
        public override int Path => BOTTOM;
        public override int Tier => 5;
        public override int Cost => 50000;
        public override string Portrait => "GlaceonPortrait";
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("IceMonkey-005").GetUpgrade(BOTTOM, 5).icon;
        public override string Description => "Increased range, damage, attack speed and pierce";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel .GetAttackModel ();
            var projectileModel = attackModel.GetDescendant<ProjectileModel>();
            towerModel.range += 20;
            attackModel.range += 20;
            projectileModel.GetDamageModel().damage += 10;
            projectileModel.pierce += 3;
            attackModel.AddBehavior(Game.instance.model.GetTowerFromId("IceMonkey-005").GetAttackModel().weapons[0].Duplicate());
            towerModel.GetWeapon().rate *= 0.75f;
        }
    }
}
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Utils;

namespace Eevee.Upgrades.TopPath
{
    public class ElectroBall : ModUpgrade <Eevee>
    {
        public override int Path => TOP;
        public override int Tier => 4;
        public override int Cost => 19000;
        public override string Portrait => "BlitzaPortrait";
        public override SpriteReference IconReference => Game.instance .model.GetTowerFromId("Druid-400").GetUpgrade (TOP,4).icon;
        public override string Description => "Jolteon attacks with an electro ball attack and increased damage";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var projectileModel = attackModel.GetDescendant<ProjectileModel>();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 2;
            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("Druid-400").GetAttackModel().weapons[2].Duplicate());
        }
    }
}

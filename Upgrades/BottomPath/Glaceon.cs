using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;

namespace Eevee.Upgrades.MiddlePath
{
    public class Glaceon : ModUpgrade<Eevee>
    {
        public override int Path => BOTTOM;
        public override int Tier => 3;
        public override int Cost => 2500;
        public override string Portrait => "GlaceonPortrait";
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("IceMonkey-004").GetUpgrade(BOTTOM, 3).icon;
        public override string Description => "Evolving Eevee to Glaceon and faster attack speed";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile = Game.instance.model.GetTowerFromId("IceMonkey-003").GetAttackModel().weapons[0].projectile.Duplicate();
            towerModel.GetWeapon().rate *= 0.8f;
            attackModel.weapons[0].projectile.SetHitCamo(true);
        }
    }
}

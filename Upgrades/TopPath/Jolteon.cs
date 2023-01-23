using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;
using BTD_Mod_Helper.Api.Display;

namespace Eevee.Upgrades.TopPath
{
    public class Jolteon : ModUpgrade <Eevee>
    {
        public override int Path => TOP;
        public override int Tier => 3;
        public override int Cost => 2800;
        public override string Portrait => "BlitzaPortrait";
        public override SpriteReference IconReference => Game.instance.model.GetTowerFromId("Druid-200").GetUpgrade(TOP, 2).icon;
        public override string Description => "Evolving Eevee to Jolteon and increases the attack speed and range";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.66f;
            towerModel.range += 10;
            var attackModel = towerModel.GetAttackModel();
            attackModel.range += 10;
            attackModel.weapons[0].projectile = Game.instance.model.GetTowerFromId("Druid-200").GetAttackModel().weapons[1].projectile.Duplicate();
            attackModel.weapons[0].projectile.SetHitCamo(true);
            towerModel.ApplyDisplay<JolteonDisplay>();
        }
    }
    public class JolteonDisplay : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            NodeLoader.NodeLoader.LoadNode(node, "Jolteon", mod);
        }
    }
}

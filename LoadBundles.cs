global using Il2CppAssets.Scripts.Models.Towers;
global using Il2CppAssets.Scripts.Unity;
global using UnityEngine;
global using MelonLoader;
global using Il2CppInterop.Runtime;
global using uObject = UnityEngine.Object;
global using Il2CppAssets.Scripts.Unity.Display;
global using Il2CppAssets.Scripts.Models.TowerSets;
using BTD_Mod_Helper.Extensions;
using static BTD_Mod_Helper.Api.ModContent;
using BTD_Mod_Helper;

namespace NodeLoader
{
    public class NodeLoader
    {
        public static void LoadNode(UnityDisplayNode node, string prefabName, BloonsMod mod)
        {
            node.GetRenderer<SpriteRenderer>().sprite = null;
            var bundle = GetBundle(mod, "eevee");
            var prefab = bundle.LoadAssetAsync(prefabName, Il2CppType.Of<uObject>()).asset;
            var eeveeGameObject = GameObject.Instantiate(prefab, node.transform .GetChild (0).transform);
            node.transform.GetChild(0).transform.localScale *= 15;
            node.transform.GetChild(0).transform.localRotation = Quaternion.Euler(0, 0, 0);
            node.transform.GetChild(0).transform.localPosition = Vector3.zero;
            node.transform.GetChild(0).transform.localPosition -= new Vector3(0, 0, 0);
        }
    }
}



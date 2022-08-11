using UnityEngine;

namespace UnityExtensions
{
    public static partial class GameObjectExtensions
    {
        public static bool IsInLayerMask(this GameObject gameObject, LayerMask layer)
        {
            return (layer.value & (1 << gameObject.layer)) != 0;
        }

        public static void SetLayer(this GameObject root, LayerMask layer)
        {
            root.layer = layer.value;
            Transform rootTransform = root.transform;
            for (var i = 0; i < rootTransform.childCount; i++)
            {
                SetLayer(rootTransform.GetChild(i).gameObject, layer);
            }
        }
    }
}
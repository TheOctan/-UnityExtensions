using UnityEngine;

namespace UnityExtensions
{
    public static partial class ColorExtensions
    {
        public static void SetAlpha(this SpriteRenderer spriteRenderer, float alpha)
        {
            Color color = spriteRenderer.color;
            spriteRenderer.color = new Color(color.r, color.g, color.b, alpha);
        }

        public static Color SetAlpha(this Color color, float alpha)
        {
            return new Color(color.r, color.g, color.b, alpha);
        }

        public static Vector3 ToVector(this Color color)
        {
            float x = LinearConverter.ColorToCoordinate(color.r);
            float y = LinearConverter.ColorToCoordinate(color.g);
            float z = LinearConverter.ColorToCoordinate(color.b);

            return new Vector3(x, y, z);
        }
    }
}
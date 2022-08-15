using UnityEngine;
using UnityExtensions.Math;

namespace UnityExtensions.Render
{
    public static partial class ColorExtensions
    {
        public static void SetStartColor(this ParticleSystem particleSystem, Color color)
        {
            ParticleSystem.MainModule main = particleSystem.main;
            main.startColor = color;
        }

        public static void SetAlpha(this ParticleSystem particleSystem, float alpha)
        {
            ParticleSystem.MainModule main = particleSystem.main;
            main.startColor = main.startColor.color.SetAlpha(alpha);
        }

        public static void SetAlpha(this SpriteRenderer spriteRenderer, float alpha)
        {
            spriteRenderer.color = spriteRenderer.color.SetAlpha(alpha);
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
using UnityEngine;
using UnityExtensions.Math;

namespace UnityExtensions.Collections
{
    public static partial class MatrixExtensions
    {
        /// <summary>
        /// Convert all values of map to brightness
        /// </summary>
        /// <param name="map"></param>
        public static void ConvertToBrightness(this float[,] map)
        {
            ConvertToColor(map);
        }

        /// <summary>
        /// Convert all values of map to brightness
        /// </summary>
        /// <param name="map"></param>
        public static void ConvertToColor(this float[,] map)
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    map[x, y] = LinearConverter.CoordinateToColor(map[x, y]);
                }
            }
        }

        /// <summary>
        /// Copy map and convert all values of map to brightness
        /// </summary>
        /// <param name="map"></param>
        /// <returns></returns>
        public static float[,] GetConvertedToBrightness(this float[,] map)
        {
            return GetConvertedToColor(map);
        }

        /// <summary>
        /// Copy map and convert all values of map to brightness
        /// </summary>
        /// <param name="map"></param>
        public static float[,] GetConvertedToColor(this float[,] map)
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);

            var newMap = new float[width, height];

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    newMap[x, y] = LinearConverter.CoordinateToColor(map[x, y]);
                }
            }

            return newMap;
        }

        /// <summary>
        /// Normalize all values between min and max
        /// </summary>
        /// <param name="map"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        public static void Normalize(this float[,] map, float minValue, float maxValue)
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    map[x, y] = Mathf.InverseLerp(minValue, maxValue, map[x, y]);
                }
            }
        }

        /// <summary>
        /// Copy map and normalize all values between min and max
        /// </summary>
        /// <param name="map"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static float[,] GetNormalized(this float[,] map, float minValue, float maxValue)
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);

            var newMap = new float[width, height];

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    newMap[x, y] = Mathf.InverseLerp(minValue, maxValue, map[x, y]);
                }
            }

            return newMap;
        }

        /// <summary>
        /// Returns min and max values from map
        /// </summary>
        /// <param name="map"></param>
        /// <returns></returns>
        public static (float min, float max) MinMax(this float[,] map)
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);

            var max = float.MinValue;
            var min = float.MaxValue;

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    if (map[x, y] > max)
                    {
                        max = map[x, y];
                    }

                    if (map[x, y] < min)
                    {
                        min = map[x, y];
                    }
                }
            }

            return (min, max);
        }
    }
}
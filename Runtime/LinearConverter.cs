using UnityEngine;

namespace UnityExtensions
{
    public static partial class LinearConverter
    {
        public static float CoordinateToColor(float value)
        {
            // XYZ=[-1..1] => RGB=[0..1]
            // return Mathf.InverseLerp(-1, 1, value);
            return (value + 1) * 0.5f;
        }

        public static float ColorToCoordinate(float value)
        {
            // RGB=[0..1] => XYZ=[-1..1]
            // return Mathf.Lerp(-1, 1, value);
            return value * 2 - 1;
        }

        public static int CoordinateToIndex(int x, int y, int width)
        {
            return x + y * width;
        }

        public static int CoordinateToIndex(int x, int y, int z, int width, int height)
        {
            return x + y * width + z * width * height;
        }

        public static (int x, int y) IndexToCoordinate(this int index, int width)
        {
            int x = index % width;
            int y = index / width;
            return (x, y);
        }

        public static (int x, int y, int z) IndexToCoordinate(this int index, int width, int height)
        {
            int x = index % width;
            int y = (index / width) % height;
            int z = index / (width * height);
            return (x, y, z);
        }

        public static Vector2Int IndexToVector(this int index, int width)
        {
            int x = index % width;
            int y = index / width;
            return new Vector2Int(x, y);
        }

        public static Vector3Int IndexToVector(this int index, int width, int height)
        {
            int x = index % width;
            int y = (index / width) % height;
            int z = index / (width * height);
            return new Vector3Int(x, y, z);
        }

        /// <summary>
        /// Convert all values of map to brightness
        /// </summary>
        /// <param name="map"></param>
        public static void ConvertToBrightness(this float[,] map)
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    map[x, y] = CoordinateToColor(map[x, y]);
                }
            }
        }

        /// <summary>
        /// Convert all values of map to brightness
        /// </summary>
        /// <param name="map"></param>
        public static void ConvertToColor(this float[,] map)
        {
            ConvertToBrightness(map);
        }

        /// <summary>
        /// Copy map and convert all values of map to color
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
                    newMap[x, y] = CoordinateToColor(map[x, y]);
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
    }
}
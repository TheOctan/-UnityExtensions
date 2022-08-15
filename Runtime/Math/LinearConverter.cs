using UnityEngine;

namespace UnityExtensions.Math
{
    public static partial class LinearConverter
    {
        /// <summary>
        /// Map the range of values from XYZ=[-1..1] to RGB=[0..1]
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float CoordinateToBrightness(float value)
        {
            return CoordinateToColor(value);
        }

        /// <summary>
        /// Map the range of values from RGB=[0..1] to XYZ=[-1..1]
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float BrightnessToCoordinate(float value)
        {
            return ColorToCoordinate(value);
        }

        /// <summary>
        /// Map the range of values from XYZ=[-1..1] to RGB=[0..1]
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float CoordinateToColor(float value)
        {
            // return Mathf.InverseLerp(-1, 1, value);
            return (value + 1) * 0.5f;
        }

        /// <summary>
        /// Map the range of values from RGB=[0..1] to XYZ=[-1..1]
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float ColorToCoordinate(float value)
        {
            // return Mathf.Lerp(-1, 1, value);
            return value * 2 - 1;
        }

        /// <summary>
        /// Convert indices of 2D array to index of 1D array
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static int CoordinateToIndex(int x, int y, int width)
        {
            return x + y * width;
        }

        /// <summary>
        /// Convert indices of 3D array to index of 1D array
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int CoordinateToIndex(int x, int y, int z, int width, int height)
        {
            return x + y * width + z * width * height;
        }

        /// <summary>
        /// Convert index of 1D array to indices of 2D array
        /// </summary>
        /// <param name="index"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static (int x, int y) IndexToCoordinate(this int index, int width)
        {
            int x = index % width;
            int y = index / width;
            return (x, y);
        }

        /// <summary>
        /// Convert index of 1D array to indices of 3D array
        /// </summary>
        /// <param name="index"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static (int x, int y, int z) IndexToCoordinate(this int index, int width, int height)
        {
            int x = index % width;
            int y = (index / width) % height;
            int z = index / (width * height);
            return (x, y, z);
        }

        /// <summary>
        /// Convert index of 1D array to indices of 2D array
        /// </summary>
        /// <param name="index"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static Vector2Int IndexToVector(this int index, int width)
        {
            int x = index % width;
            int y = index / width;
            return new Vector2Int(x, y);
        }

        /// <summary>
        /// Convert index of 1D array to indices of 3D array
        /// </summary>
        /// <param name="index"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Vector3Int IndexToVector(this int index, int width, int height)
        {
            int x = index % width;
            int y = (index / width) % height;
            int z = index / (width * height);
            return new Vector3Int(x, y, z);
        }
    }
}
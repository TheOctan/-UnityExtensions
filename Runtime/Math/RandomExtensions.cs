using UnityEngine;

namespace UnityExtensions.Math
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// Generate random normalized direction
        /// </summary>
        /// <returns></returns>
        public static Vector2 RandomDir()
        {
            return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xMin"></param>
        /// <param name="xMax"></param>
        /// <param name="yMin"></param>
        /// <param name="yMax"></param>
        /// <returns></returns>
        public static Vector3 RandomPositionInsideRect(float xMin, float xMax, float yMin, float yMax)
        {
            return new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lowerLeft"></param>
        /// <param name="upperRight"></param>
        /// <returns></returns>
        public static Vector3 RandomPositionInsideRect(Vector3 lowerLeft, Vector3 upperRight)
        {
            return new Vector3(Random.Range(lowerLeft.x, upperRight.x), Random.Range(lowerLeft.y, upperRight.y));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chance"></param>
        /// <param name="chanceMax"></param>
        /// <returns></returns>
        public static bool TestChance(int chance, int chanceMax = 100)
        {
            return Random.Range(0, chanceMax) < chance;
        }
    }
}
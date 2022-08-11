using System;
using System.Collections.Generic;

namespace UnityExtensions
{
    public static partial class CollectionExtensions
    {
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            return list.Shuffle(DateTime.Now.Second);
        }

        public static IList<T> Shuffle<T>(this IList<T> list, int seed)
        {
            var random = new Random(seed);
            for (var i = 0; i < list.Count - 1; i++)
            {
                int randomIndex = random.Next(i, list.Count);

                (list[randomIndex], list[i]) = (list[i], list[randomIndex]);
            }

            return list;
        }

        public static T RandomItem<T>(this List<T> list)
        {
            return RandomItem(list, DateTime.Now.Second);
        }

        public static T RandomItem<T>(this List<T> list, int seed)
        {
            var random = new Random(seed);
            int index = random.Next(0, list.Count);
            return list[index];
        }

        public static T RandomByChance<T>(this List<T> list) where T : IRandomChance
        {
            return RandomByChance(list, DateTime.Now.Second);
        }

        public static T RandomByChance<T>(this List<T> list, int seed) where T : IRandomChance
        {
            var random = new Random(seed);

            var total = 0f;
            var probes = new float[list.Count];
            for (var i = 0; i < probes.Length; i++)
            {
                probes[i] = list[i].Chance;
                total += probes[i];
            }

            float randomPoint = (float)random.NextDouble() * total;

            for (var i = 0; i < probes.Length; i++)
            {
                if (randomPoint < probes[i])
                {
                    return list[i];
                }

                randomPoint -= probes[i];
            }

            return list[0];
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

        public interface IRandomChance
        {
            public float Chance { get; }
        }
    }
}
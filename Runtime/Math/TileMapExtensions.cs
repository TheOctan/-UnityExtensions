using System.Collections.Generic;
using UnityEngine;

namespace UnityExtensions.Math
{
    public static partial class TileMapExtensions
    {
        #region Neighbours

        public static List<Vector2Int> GetNeighbours(this Vector2Int[,] map, Vector2Int currentNode)
        {
            var neighbourList = new List<Vector2Int>();

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (x == 0 && y == 0)
                    {
                        continue;
                    }

                    int neighbourX = currentNode.x + x;
                    int neighbourY = currentNode.y + y;

                    if (neighbourX >= 0 && neighbourX < map.GetLength(0)
                                        && neighbourY >= 0 && neighbourY < map.GetLength(1))
                    {
                        neighbourList.Add(map[neighbourX, neighbourY]);
                    }
                }
            }

            return neighbourList;
        }

        public static List<T> GetNeighbours<TM, T>(this TM map, T currentNode)
            where TM : IReadOnlyTileMap<T>
            where T : IReadOnlyTile
        {
            var neighbourList = new List<T>();

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (x == 0 && y == 0)
                    {
                        continue;
                    }

                    int neighbourX = currentNode.X + x;
                    int neighbourY = currentNode.Y + y;

                    if (neighbourX >= 0 && neighbourX < map.Width
                                        && neighbourY >= 0 && neighbourY < map.Height)
                    {
                        neighbourList.Add(map.GetTile(neighbourX, neighbourY));
                    }
                }
            }

            return neighbourList;
        }

        #endregion

        #region TilePosition

        

        #endregion

        #region WorldPosition

        public static Vector2 CoordinateToOriginPosition(int xPosition, int yPosition, int xMapSize, int yMapSize,
            Vector2 pivot, float tileSize)
        {
            return CoordinateToOriginPosition(new Vector2Int(xPosition, yPosition),
                new Vector2Int(xMapSize, yMapSize), pivot, tileSize);
        }

        public static Vector2 CoordinateToOriginPosition(this Vector2Int position, Vector2Int mapSIze, Vector2 pivot,
            float tileSize)
        {
            Vector2 tileCoordinate = -mapSIze.ToVector2() * pivot + position.TileCenter();
            return tileCoordinate.CoordinateToPosition(tileSize);
        }

        public static Vector3 CoordinateToOriginPosition(this Vector3Int position, Vector3Int mapSIze, Vector3 pivot,
            float tileSize)
        {
            Vector3 tileCoordinate = -mapSIze.Multiply(pivot) + position.TileCenter();
            return tileCoordinate.CoordinateToPosition(tileSize);
        }

        public static Vector2 CoordinateToPosition(int x, int y, float tileSize)
        {
            return new Vector2(x, y) * tileSize;
        }

        public static Vector2 CoordinateToPosition(this Vector2 position, float tileSize)
        {
            return position * tileSize;
        }

        public static Vector3 CoordinateToPosition(this Vector3 position, float tileSize)
        {
            return position * tileSize;
        }

        public static Vector2 CoordinateToPosition(this Vector2Int position, float tileSize)
        {
            return position.ToVector2() * tileSize;
        }

        public static Vector3 CoordinateToPosition(this Vector3Int position, float tileSize)
        {
            return position.ToVector3() * tileSize;
        }

        #endregion

        #region TileCenter

        public static Vector2 TileCenter(this Vector2 v)
        {
            return new Vector2(v.x + 0.5f, v.y + 0.5f);
        }

        public static Vector3 TileCenter(this Vector3 v)
        {
            return new Vector3(v.x + 0.5f, v.y + 0.5f, v.z + 0.5f);
        }

        public static Vector2 TileCenter(this Vector2Int v)
        {
            return new Vector2(v.x + 0.5f, v.y + 0.5f);
        }

        public static Vector3 TileCenter(this Vector3Int v)
        {
            return new Vector3(v.x + 0.5f, v.y + 0.5f, v.x + 0.5f);
        }

        #endregion
    }

    public interface IReadOnlyTile
    {
        Vector2Int Position { get; }
        int X { get; }
        int Y { get; }
    }

    public interface ITile : IReadOnlyTile
    {
        new Vector2Int Position { get; set; }
        new int X { get; set;}
        new int Y { get; set;}
    }

    public interface IReadOnlyTileMap<out T> where T : IReadOnlyTile
    {
        int Width { get; }
        int Height { get; }
        Vector2Int Size { get; }
        T GetTile(Vector2Int tile);
        T GetTile(int x, int y);
    }
}
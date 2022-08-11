using UnityEngine;

namespace UnityExtensions
{
    public static partial class VectorExtensions
    {
        public static Vector2 Rotate(this Vector2 v, float degrees)
        {
            float radians = degrees * Mathf.Deg2Rad;
            float sin = Mathf.Sin(radians);
            float cos = Mathf.Cos(radians);
 
            return new Vector2(cos * v.x - sin * v.y, sin * v.x + cos * v.y);
        }

        #region Convert

        public static Color ToColor(this Vector3 vector)
        {
            float r = LinearConverter.CoordinateToColor(vector.x);
            float g = LinearConverter.CoordinateToColor(vector.y);
            float b = LinearConverter.CoordinateToColor(vector.z);

            return new Color(r, g, b);
        }

        public static int ToIndex(this Vector2Int coordinate, int width)
        {
            return LinearConverter.CoordinateToIndex(coordinate.x, coordinate.y, width);
        }

        public static int ToIndex(this Vector3Int coordinate, int width, int height)
        {
            return LinearConverter.CoordinateToIndex(coordinate.x, coordinate.y, coordinate.z, width, height);
        }

        #endregion

        #region Abs

        public static Vector3 Abs(this Vector3 v)
        {
            return new Vector3(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z));
        }
        
        public static Vector2 Abs(this Vector2 v)
        {
            return new Vector2(Mathf.Abs(v.x), Mathf.Abs(v.y));
        }

        public static Vector3Int Abs(this Vector3Int v)
        {
            return new Vector3Int(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z));
        }
        
        public static Vector2Int Abs(this Vector2Int v)
        {
            return new Vector2Int(Mathf.Abs(v.x), Mathf.Abs(v.y));
        }

        #endregion

        #region Max

        public static float Max(this Vector3 v)
        {
            return Mathf.Max(v.x, Mathf.Max(v.y, v.z));
        }

        public static float Max(this Vector2 v)
        {
            return Mathf.Max(v.x, v.y);
        }

        public static int Max(this Vector3Int v)
        {
            return Mathf.Max(v.x, Mathf.Max(v.y, v.z));
        }

        public static int Max(this Vector2Int v)
        {
            return Mathf.Max(v.x, v.y);
        }

        #endregion

        #region Min

        public static float Min(this Vector3 v)
        {
            return Mathf.Min(v.x, Mathf.Min(v.y, v.z));
        }

        public static float Min(this Vector2 v)
        {
            return Mathf.Min(v.x, v.y);
        }

        public static int Min(this Vector3Int v)
        {
            return Mathf.Min(v.x, Mathf.Min(v.y, v.z));
        }

        public static int Min(this Vector2Int v)
        {
            return Mathf.Min(v.x, v.y);
        }

        #endregion

        #region Ceil

        public static Vector3 Ceil(this Vector3 v)
        {
            return new Vector3(Mathf.Ceil(v.x), Mathf.Ceil(v.y), Mathf.Ceil(v.z));
        }

        public static Vector2 Ceil(this Vector2 v)
        {
            return new Vector2(Mathf.Ceil(v.x), Mathf.Ceil(v.y));
        }

        #endregion

        #region Floor

        public static Vector3 Floor(this Vector3 v)
        {
            return new Vector3(Mathf.Floor(v.x), Mathf.Floor(v.y), Mathf.Floor(v.z));
        }

        public static Vector2 Floor(this Vector2 v)
        {
            return new Vector2(Mathf.Floor(v.x), Mathf.Floor(v.y));
        }

        #endregion

        #region Round

        public static Vector3 Round(this Vector3 v)
        {
            return new Vector3(Mathf.Round(v.x), Mathf.Round(v.y), Mathf.Round(v.z));
        }

        public static Vector2 Round(this Vector2 v)
        {
            return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));
        }

        #endregion

        #region SetX

        public static Vector3 SetX(this Vector3 v, float x)
        {
            return new Vector3(x, v.y, v.z);
        }

        public static Vector2 SetX(this Vector2 v, float x)
        {
            return new Vector2(x, v.y);
        }
        
        public static Vector3Int SetX(this Vector3Int v, int x)
        {
            return new Vector3Int(x, v.y, v.z);
        }
        
        public static Vector2Int SetX(this Vector2Int v, int x)
        {
            return new Vector2Int(x, v.y);
        }

        #endregion

        #region SetY

        public static Vector3 SetY(this Vector3 v, float y)
        {
            return new Vector3(v.x, y, v.z);
        }
        
        public static Vector2 SetY(this Vector2 v, float y)
        {
            return new Vector2(v.x, y);
        }
        
        public static Vector3Int SetY(this Vector3Int v, int y)
        {
            return new Vector3Int(v.x, y, v.z);
        }
        
        public static Vector2Int SetY(this Vector2Int v, int y)
        {
            return new Vector2Int(v.x, y);
        }

        #endregion

        #region SetZ

        public static Vector3 SetZ(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, z);
        }

        public static Vector3Int SetZ(this Vector3Int v, int z)
        {
            return new Vector3Int(v.x, v.y, z);
        }

        #endregion

        #region TileCenter

        public static Vector2 TileCenter(this Vector2 v)
        {
            return new Vector2(v.x + 0.5f, v.y + 0.5f);
        }
 
        public static Vector2 TileCenter(this Vector3 v)
        {
            return new Vector2(v.x + 0.5f, v.y + 0.5f);
        }

        public static Vector2 TileCenter(this Vector2Int v)
        {
            return new Vector2(v.x + 0.5f, v.y + 0.5f);
        }
 
        public static Vector2 TileCenter(this Vector3Int v)
        {
            return new Vector2(v.x + 0.5f, v.y + 0.5f);
        }

        #endregion

        #region Half

        public static Vector2 Half(this Vector2 v)
        {
            return v * 0.5f;
        }
        
        public static Vector3 Half(this Vector3 v)
        {
            return v * 0.5f;
        }

        public static Vector2Int Half(this Vector2Int v)
        {
            return v / 2;
        }
        
        public static Vector3Int Half(this Vector3Int v)
        {
            return v / 2;
        }

        #endregion

        #region ToVector2

        public static Vector2 ToVector2(this Vector3 v)
        {
            return v;
        }

        public static Vector2 ToVector2(this Vector2Int v)
        {
            return v;
        }

        public static Vector2 ToVector2(this Vector3Int v)
        {
            return new Vector2(v.x, v.y);
        }

        #endregion

        #region ToVector3

        public static Vector3 ToVector3(this Vector2 v)
        {
            return v;
        }

        public static Vector3 ToVector3(this Vector2Int v)
        {
            return new Vector3(v.x, v.y);
        }

        public static Vector3 ToVector3(this Vector3Int v)
        {
            return v;
        }

        #endregion

        #region ToVector2Int

        public static Vector2Int ToVector2IntCeil(this Vector2 v)
        {
            return new Vector2Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y));
        }

        public static Vector2Int ToVector2IntFloor(this Vector2 v)
        {
            return new Vector2Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y));
        }

        public static Vector2Int ToVector2IntRound(this Vector2 v)
        {
            return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
        }

        public static Vector2Int ToVector2IntCeil(this Vector3 v)
        {
            return new Vector2Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y));
        }

        public static Vector2Int ToVector2IntFloor(this Vector3 v)
        {
            return new Vector2Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y));
        }

        public static Vector2Int ToVector2IntRound(this Vector3 v)
        {
            return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
        }

        public static Vector2Int ToVector2Int(this Vector3Int v)
        {
            return new Vector2Int(v.x, v.y);
        }

        #endregion

        #region ToVector3Int

        public static Vector3Int ToVector3IntCeil(this Vector2 v)
        {
            return new Vector3Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.x), 0);
        }

        public static Vector3Int ToVector3IntFloor(this Vector2 v)
        {
            return new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.x), 0);
        }

        public static Vector3Int ToVector3IntRound(this Vector2 v)
        {
            return new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.x), 0);
        }

        public static Vector3Int ToVector3IntCeil(this Vector3 v)
        {
            return new Vector3Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y), Mathf.CeilToInt(v.z));
        }

        public static Vector3Int ToVector3IntFloor(this Vector3 v)
        {
            return new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z));
        }

        public static Vector3Int ToVector3IntRound(this Vector3 v)
        {
            return new Vector3Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z));
        }

        public static Vector3Int ToVector3Int(this Vector2Int v)
        {
            return new Vector3Int(v.x, v.y, 0);
        }

        #endregion
    }
}
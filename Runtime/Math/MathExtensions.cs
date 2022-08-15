using UnityEngine;

namespace UnityExtensions.Math
{
    public static partial class MathExtensions
    {
        #region Abs

        public static int Abs(this int value)
        {
            return Mathf.Abs(value);
        }
        
        public static float Abs(this float value)
        {
            return Mathf.Abs(value);
        }
        
        public static double Abs(this double value)
        {
            return System.Math.Abs(value);
        }

        #endregion

        #region Distance

        public static int Distance(this int start, int destination)
        {
            return destination - start;
        }
        
        public static float Distance(this float start, float destination)
        {
            return destination - start;
        }
        
        public static double Distance(this double start, double destination)
        {
            return destination - start;
        }

        #endregion

        #region NotEquals

        public static bool NotEquals<T>(this T a, T b)
        {
            return !a.Equals(b);
        }

        #endregion

        #region More

        public static bool More(this int a, int b)
        {
            return a > b;
        }

        public static bool More(this uint a, uint b)
        {
            return a > b;
        }

        public static bool More(this float a, float b)
        {
            return a > b;
        }

        public static bool More(this double a, double b)
        {
            return a > b;
        }

        public static bool More(this long a, long b)
        {
            return a > b;
        }

        public static bool More(this decimal a, decimal b)
        {
            return a > b;
        }

        #endregion

        #region Less

        public static bool Less(this int a, int b)
        {
            return a < b;
        }

        public static bool Less(this uint a, uint b)
        {
            return a < b;
        }

        public static bool Less(this float a, float b)
        {
            return a < b;
        }

        public static bool Less(this double a, double b)
        {
            return a < b;
        }

        public static bool Less(this long a, long b)
        {
            return a < b;
        }

        public static bool Less(this decimal a, decimal b)
        {
            return a < b;
        }

        #endregion

        #region MoreOrEquals

        public static bool MoreOrEquals(this int a, int b)
        {
            return a >= b;
        }

        public static bool MoreOrEquals(this uint a, uint b)
        {
            return a >= b;
        }

        public static bool MoreOrEquals(this float a, float b)
        {
            return a >= b;
        }

        public static bool MoreOrEquals(this double a, double b)
        {
            return a >= b;
        }

        public static bool MoreOrEquals(this long a, long b)
        {
            return a >= b;
        }

        public static bool MoreOrEquals(this decimal a, decimal b)
        {
            return a >= b;
        }

        #endregion

        #region LessOrEquals

        public static bool LessOrEquals(this int a, int b)
        {
            return a <= b;
        }

        public static bool LessOrEquals(this uint a, uint b)
        {
            return a <= b;
        }

        public static bool LessOrEquals(this float a, float b)
        {
            return a <= b;
        }

        public static bool LessOrEquals(this double a, double b)
        {
            return a <= b;
        }

        public static bool LessOrEquals(this long a, long b)
        {
            return a <= b;
        }

        public static bool LessOrEquals(this decimal a, decimal b)
        {
            return a <= b;
        }

        #endregion
    }
}
using UnityEngine;
using UnityUtilities.Misc;

namespace UnityUtilities.Extensions
{
    public static class MiscellaneousExtensions
    {
        /// <summary>
        /// Transforms a float array (of size 2) to a Vector 2. 
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Vector2 from array</returns>
        public static Vector2 ToVector2(this float[] array)
        {
            if (array.Length != 2) return Vector2.negativeInfinity;

            return new Vector2(array[0], array[1]);
        }

        /// <summary>
        /// Calculates distance between two coordinates. See this <a href="https://stackoverflow.com/a/51839058/12548708">post</a> for more info.
        /// </summary>
        /// <param name="oneVec">One coordinate.</param>
        /// <param name="anotherVec">Another coordinate.</param>
        /// <returns>Distance in meters.</returns>
        public static float GeoDistanceTo(this Vector2 oneVec, Vector2 anotherVec)
        {
            var d1 = oneVec.x * Mathf.Deg2Rad;
            var num1 = oneVec.y * Mathf.Deg2Rad;
            var d2 = anotherVec.x * Mathf.Deg2Rad;
            var num2 = anotherVec.y * Mathf.Deg2Rad - num1;
            var d3 = Mathf.Pow(Mathf.Sin((d2 - d1) / 2.0f), 2.0f) + Mathf.Cos(d1) * Mathf.Cos(d2) * Mathf.Pow(Mathf.Sin(num2 / 2.0f), 2.0f);

            return Constants.EarthRadius * (2.0f * Mathf.Atan2(Mathf.Sqrt(d3), Mathf.Sqrt(1.0f - d3)));
        }
    }
}
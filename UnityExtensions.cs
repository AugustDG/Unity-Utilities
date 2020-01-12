using UnityEngine;

namespace Utilities.Extensions
{
    internal static class UnityExtensions
    {
        /// <summary> 
        /// More elegant way of writing Destroy(gameObject).
        /// </summary>
        public static void Destroy(this GameObject go)
        {
            Object.Destroy(go);
        }
        
        //TODO: Reduce to single function for all vector types
        
        /// <summary> 
        /// Returns the corresponding unit vector to the given angle (in degrees).
        /// </summary>
        public static Vector2 Vectorize(this float angle, float magnitude = 1f)
        {
            return new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad))*magnitude;
        }
        
        /// <summary> 
        /// Returns the corresponding unit vector to the given angle (in degrees).
        /// </summary>
        public static Vector2 Vectorize(this int angle, int magnitude = 1)
        {
            return new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad))*magnitude;
        }

        /// <summary> 
        /// Returns the positive angle in degrees of given Vector2. This method assumes +X axis is 0 degrees. 
        /// </summary>
        /// <param name="vector2"></param>
        /// <param name="angleOffset"></param>
        public static float Rotation(this Vector2 vector2, float angleOffset = 0f)
        {
            return Mathf.Atan2(vector2.y, vector2.x) * Mathf.Rad2Deg + angleOffset;
        }

        /// <summary> 
        /// Rotates the Vector2 by given angle. 
        /// </summary>
        public static Vector2 Rotate(this Vector2 v, float degrees)
        {
            float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
            float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);

            float tx = v.x;
            float ty = v.y;
            v.x = (cos * tx) - (sin * ty);
            v.y = (sin * tx) + (cos * ty);
            return v;
        }
        
        /// <summary>
        ///     Rounds Vector3.
        /// </summary>
        /// <param name="vector3"></param>
        /// <param name="decimalPlaces"></param>
        /// <returns></returns>
        public static Vector3 Round(this Vector3 vector3, int decimalPlaces = 2)
        {
            float multiplier = 1;
            for (var i = 0; i < decimalPlaces; i++) multiplier *= 10f;
            return new Vector3(
                Mathf.Round(vector3.x * multiplier) / multiplier,
                Mathf.Round(vector3.y * multiplier) / multiplier,
                Mathf.Round(vector3.z * multiplier) / multiplier);
        }

        /// <summary>
        ///     Rounds Vector2.
        /// </summary>
        /// <param name="vector2"></param>
        /// <param name="decimalPlaces"></param>
        /// <returns></returns>
        public static Vector2 Round(this Vector2 vector2, int decimalPlaces = 2)
        {
            float multiplier = 1;
            for (var i = 0; i < decimalPlaces; i++) multiplier *= 10f;
            return new Vector2(
                Mathf.Round(vector2.x * multiplier) / multiplier,
                Mathf.Round(vector2.y * multiplier) / multiplier);
        }
    }
}
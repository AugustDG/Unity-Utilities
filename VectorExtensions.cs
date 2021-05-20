using UnityUtilities;
using UnityEngine;
using UnityUtilities.Misc;

namespace UnityUtilities.Extensions
{
    public static class VectorExtensions
    {
        /// <summary>
        ///     Rounds Vector3.
        /// </summary>
        /// <param name="vector3"></param>
        /// <returns>Rounded Vector3Int</returns>
        public static Vector3Int RoundToInt(this Vector3 vector3)
        {
            return new Vector3Int(
                vector3.x.RoundToInt(),
                vector3.y.RoundToInt(),
                vector3.z.RoundToInt());
        }

        /// <summary>
        ///     Rounds Vector3 to the specified number of decimals.
        /// </summary>
        /// <param name="vector3"></param>
        /// <param name="decimalPlaces"></param>
        /// <returns>Rounded Vector3</returns>
        public static Vector3 Round(this Vector3 vector3, int decimalPlaces = 0)
        {
            float multiplier = 1;
            for (var i = 0; i < decimalPlaces; i++) multiplier *= 10f;
            return new Vector3(
                Mathf.Round(vector3.x * multiplier) / multiplier,
                Mathf.Round(vector3.y * multiplier) / multiplier,
                Mathf.Round(vector3.z * multiplier) / multiplier);
        }

        /// <summary>
        ///     Clamps Vector3 components between 0 and 1.
        /// </summary>
        /// <param name="vector3"></param>
        /// <returns>Clamped Vector3</returns>
        public static Vector3 Clamp(this Vector3 vector3)
        {
            return new Vector3(
                Mathf.Clamp01(vector3.x),
                Mathf.Clamp01(vector3.y),
                Mathf.Clamp01(vector3.z));
        }

        /// <summary>
        ///     Clamps Vector3 components between provided values.
        /// </summary>
        /// <param name="vector3"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Clamped Vector3</returns>
        public static Vector3 Clamp(this Vector3 vector3, float min, float max)
        {
            return new Vector3(
                Mathf.Clamp(vector3.x, min, max),
                Mathf.Clamp(vector3.y, min, max),
                Mathf.Clamp(vector3.z, min, max));
        }

        /// <summary>
        ///     Rounds Vector2.
        /// </summary>
        /// <param name="vector2"></param>
        /// <returns>Vector2Int</returns>
        public static Vector2Int RoundToInt(this Vector2 vector2)
        {
            return new Vector2Int(
                vector2.x.RoundToInt(),
                vector2.y.RoundToInt());
        }

        /// <summary>
        ///     Rounds Vector2 to the specified number of decimals.
        /// </summary>
        /// <param name="vector2"></param>
        /// <param name="decimalPlaces"></param>
        /// <returns>Rounded Vector2</returns>
        public static Vector2 Round(this Vector2 vector2, int decimalPlaces = 0)
        {
            var multiplier = 1f;
            for (var i = 0; i < decimalPlaces; i++) multiplier *= 10f;
            return new Vector2(
                Mathf.Round(vector2.x * multiplier) / multiplier,
                Mathf.Round(vector2.y * multiplier) / multiplier);
        }

        /// <summary>
        ///     Clamps Vector2 components between provided values.
        /// </summary>
        /// <param name="vector2"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Clamped Vector2</returns>
        public static Vector2 Clamp(this Vector2 vector2, float min, float max)
        {
            return new Vector2(
                Mathf.Clamp(vector2.x, min, max),
                Mathf.Clamp(vector2.y, min, max));
        }

        /// <summary>
        ///     Transforms a Vector2 to a Vector3 with Unity's (x, z) 2D coordinate system in mind.
        /// </summary>
        /// <param name="vector2"></param>
        /// <returns>Transformed Vector3</returns>
        public static Vector3 TransformTo2DVector3(this Vector2 vector2)
        {
            return new Vector3(vector2.x, 0, vector2.y);
        }

        /// <summary>
        ///     Chops a Vector3 to a Vector3 with Unity's (x, z) 2D coordinate system in mind.
        /// </summary>
        /// <param name="vector3"></param>
        /// <param name="y">Optional parameter to give the Vector3 a specific y value (generally called depth in Unity's 2D mode).</param>
        /// <returns>Chopped Vector3</returns>
        public static Vector3 ChopTo2DVector3(this Vector3 vector3, float y = 0f)
        {
            return new Vector3(vector3.x, y, vector3.z);
        }

        /// <summary> 
        /// Returns the corresponding vector of the given angle (in degrees or radians). This method assumes +X is 0 degrees/radians.
        /// <param name="magnitude"> Desired vector magnitude. </param>
        /// <param name="unitType"> Specifies if in degrees or radians. </param>
        /// </summary>
        /// <returns>Vector2 from angle</returns>
        public static Vector2 VectorFromAngle(this float angle, UnitType unitType = UnitType.Deg, float magnitude = 1f)
        {
            var converter = unitType == UnitType.Deg ? Mathf.Rad2Deg : 1;

            return new Vector2(
                Mathf.Cos(angle * converter),
                Mathf.Sin(angle * converter)) * magnitude;
        }

        /// <summary> 
        /// Returns the positive angle in degrees or radians of the given Vector2. This method assumes +X axis is 0 degrees/radians.
        /// </summary>
        /// <param name="vector2"></param>
        /// <param name="unitType">Specifies if in degrees or radians.</param>
        /// <param name="angleOffset"> In degrees or radians. </param>
        /// <returns>Angle from Vector2</returns>
        public static float AngleFromVector(this Vector2 vector2, UnitType unitType = UnitType.Deg, float angleOffset = 0f)
        {
            var converter = unitType == UnitType.Deg ? Mathf.Rad2Deg : 1;
            return Mathf.Atan2(vector2.y, vector2.x) * converter + angleOffset;
        }

        /// <summary> 
        /// Rotates the Vector2 by the given angle (in degrees or radians).
        /// <param name="angle"> In degrees. </param>
        /// </summary>
        /// <returns>Rotated Vector2</returns>
        public static Vector2 RotateByAngle(this Vector2 v, float angle, UnitType unitType)
        {
            var converter = unitType == UnitType.Deg ? Mathf.Rad2Deg : 1;

            v.x = Mathf.Cos((angle + v.AngleFromVector(unitType)) * converter) * v.magnitude;
            v.y = Mathf.Sin((angle + v.AngleFromVector(unitType)) * converter) * v.magnitude;

            return v;
        }

        ///////////////////////////
        // MISCELLANEOUS SECTION //
        ///////////////////////////

        /// <summary>
        /// Transforms a 2-big float array to a Vector 2. 
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Vector2 from array</returns>
        public static Vector2 ToVector2(this float[] array)
        {
            if (array.Length != 2) return Vector2.negativeInfinity;

            return new Vector2(array[0], array[1]);
        }

        /// <summary>
        /// Calculates distance between two coordinates.
        /// </summary>
        /// <param name="oneVec">One coordinate.</param>
        /// <param name="anotherVec">Another coordinate.</param>
        /// <seealso cref="https://stackoverflow.com/a/51839058/12548708"/>
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
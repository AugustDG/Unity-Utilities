﻿using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Utilities.Extensions
{
    public static class UnityExtensions
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
        /// Returns the corresponding vector to the given angle (in degrees).
        /// <param name="magnitude"> Desired vector magnitude. </param>
        /// </summary>
        public static Vector2 VectorFromAngleDeg(this ValueType angle, float magnitude = 1f)
        {
            return new Vector2(Mathf.Cos((float)angle * Mathf.Deg2Rad), Mathf.Sin((float)angle * Mathf.Deg2Rad))*magnitude;
        }
        
        /// <summary> 
        /// Returns the corresponding vector to the given angle (in radians).
        /// <param name="magnitude"> Desired vector magnitude. </param>
        /// </summary>
        public static Vector2 VectorFromAngleRad(this ValueType angle, float magnitude = 1f)
        {
            return new Vector2(Mathf.Cos((float)angle), Mathf.Sin((float)angle))*magnitude;
        }

        /// <summary> 
        /// Returns the positive angle in degrees of given Vector2. This method assumes +X axis is 0 degrees.
        /// </summary>
        /// <param name="vector2"></param>
        /// <param name="angleOffset"> In degrees. </param>
        public static float AngleFromVectorDeg(this Vector2 vector2, float angleOffset = 0f)
        {
            return Mathf.Atan2(vector2.y, vector2.x) * Mathf.Rad2Deg + angleOffset;
        }
        
        /// <summary> 
        /// Returns the positive angle in radians of given Vector2. This method assumes +X axis is 0 degrees. 
        /// </summary>
        /// <param name="vector2"></param>
        /// <param name="angleOffset"> In degrees. </param>
        public static float AngleFromVectorRad(this Vector2 vector2, float angleOffset = 0f)
        {
            return Mathf.Atan2(vector2.y, vector2.x) + angleOffset * Mathf.Deg2Rad;
        }

        /// <summary> 
        /// Rotates the Vector2 by the given angle (in degrees).
        /// <param name="angle"> In degrees. </param>
        /// </summary>
        public static Vector2 RotateByAngleDeg(this ref Vector2 v, float angle)
        {
            float x = Mathf.Cos((angle + v.AngleFromVectorDeg()) * Mathf.Deg2Rad) * v.magnitude;
            float y = Mathf.Sin((angle + v.AngleFromVectorDeg()) * Mathf.Deg2Rad) * v.magnitude;

            v.x = x;
            v.y = y;
            
            return v;
        }
        
        /// <summary> 
        /// Rotates the Vector2 by the given angle (in radians).
        /// <param name="angle"> In radians. </param>
        /// </summary>
        public static Vector2 RotateByAngleRad(this ref Vector2 v, float angle)
        {
            float x = Mathf.Cos(angle + v.AngleFromVectorRad()) * v.magnitude;
            float y = Mathf.Sin(angle + v.AngleFromVectorRad()) * v.magnitude;

            v.x = x;
            v.y = y;
            
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
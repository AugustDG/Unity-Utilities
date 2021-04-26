using System;
using System.Collections;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Utilities.Extensions
{
    public enum LogTypes
    {
        Message,
        Warning,
        Error
    }

    public static class UnityExtensions
    {
        /// <summary> 
        /// Delays action by specified number of seconds
        /// </summary>
        public static Coroutine DelayAction(MonoBehaviour monoBehaviour, Action delayedAction, float timeInSec)
        {
            return monoBehaviour.StartCoroutine(DelayActionRoutine(delayedAction, timeInSec));
        }

        private static IEnumerator DelayActionRoutine(Action delayedAction, float timeInSec)
        {
            yield return new WaitForSecondsRealtime(timeInSec);
            
            delayedAction.Invoke();
        }
        
        /// <summary> 
        /// More elegant way of writing Destroy(gameObject).
        /// </summary>
        public static void Destroy(this GameObject go)
        {
            Object.Destroy(go);
        }
        
        /// <summary> 
        /// More elegant way of writing DestroyImmediate(gameObject).
        /// </summary>
        public static void DestroyImmediate(this GameObject go)
        {
            Object.DestroyImmediate(go);
        }

        /// <summary> 
        /// Smoothly makes the Rigidbody2D follow the current mouse position.
        /// Should be used in FixedUpdate (recommended).
        /// <param name="speed">Follow speed.</param>
        /// <param name="rotateSpeed">Turning speed.</param>
        /// </summary>
        public static void FollowMouse2D(this Rigidbody2D rb, float speed = 5f, float rotateSpeed = 200f)
        {
            // Homing behaviour from: https://github.com/Brackeys/Homing-Missile/blob/master/Homing%20Missile/Assets/HomingMissile.cs

            var direction = (Vector2) Camera.current.ScreenToWorldPoint(Input.mousePosition) - rb.position;

            var localUp = rb.transform.up;

            direction.Normalize();

            var rotateAmount = Vector3.Cross(direction, localUp).z;

            rb.angularVelocity = -rotateAmount * rotateSpeed;

            rb.velocity = localUp * speed;
        }

        /// <summary> 
        /// Smoothly makes the Rigidbody2D follow the specified object.
        /// Should be used in FixedUpdate (recommended).
        /// <param name="go">Gameobject to follow.</param>
        /// <param name="speed">Follow speed.</param>
        /// <param name="rotateSpeed">Turning speed.</param>
        /// </summary>
        public static void FollowObject2D(this Rigidbody2D rb, GameObject go, float speed = 5f,
            float rotateSpeed = 200f)
        {
            // Homing behaviour from: https://github.com/Brackeys/Homing-Missile/blob/master/Homing%20Missile/Assets/HomingMissile.cs

            var direction = (Vector2) go.transform.position - rb.position;

            var localUp = rb.transform.up;

            direction.Normalize();

            var rotateAmount = Vector3.Cross(direction, localUp).z;

            rb.angularVelocity = -rotateAmount * rotateSpeed;

            rb.velocity = localUp * speed;
        }

        /// <summary> 
        /// Smoothly makes the Rigidbody2D follow the specified transform.
        /// Should be used in FixedUpdate (recommended).
        /// <param name="trans">Transform to follow.</param>
        /// <param name="speed">Follow speed.</param>
        /// <param name="rotateSpeed">Turning speed.</param>
        /// </summary>
        public static void FollowObject2D(this Rigidbody2D rb, Transform trans, float speed = 5f,
            float rotateSpeed = 200f)
        {
            // Homing behaviour from: https://github.com/Brackeys/Homing-Missile/blob/master/Homing%20Missile/Assets/HomingMissile.cs

            var direction = (Vector2) trans.position - rb.position;

            var localUp = rb.transform.up;

            direction.Normalize();

            var rotateAmount = Vector3.Cross(direction, localUp).z;

            rb.angularVelocity = -rotateAmount * rotateSpeed;

            rb.velocity = localUp * speed;
        }

        /// <summary> 
        /// Smoothly translates GameObject up.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoUp(this GameObject go, float speed = 1f)
        {
            go.transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
        }

        /// <summary> 
        /// Smoothly translates GameObject down.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoDown(this GameObject go, float speed = 1f)
        {
            go.transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);
        }

        /// <summary> 
        /// Smoothly translates GameObject left.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoLeft(this GameObject go, float speed = 1f)
        {
            go.transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }

        /// <summary> 
        /// Smoothly translates GameObject right.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoRight(this GameObject go, float speed = 1f)
        {
            go.transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }

        /// <summary> 
        /// Smoothly translates GameObject forwards.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoForward(this GameObject go, float speed = 1f)
        {
            go.transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        }

        /// <summary> 
        /// Smoothly translates GameObject backwards.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoBackward(this GameObject go, float speed = 1f)
        {
            go.transform.Translate(Vector3.back * Time.deltaTime * speed, Space.World);
        }

        //TODO: Reduce to single function for all vector types

        /// <summary> 
        /// Returns the corresponding vector to the given angle (in degrees).
        /// <param name="magnitude"> Desired vector magnitude. </param>
        /// </summary>
        public static Vector2 VectorFromAngleDeg(this ValueType angle, float magnitude = 1f)
        {
            return new Vector2(Mathf.Cos((float) angle * Mathf.Deg2Rad), Mathf.Sin((float) angle * Mathf.Deg2Rad)) *
                   magnitude;
        }

        /// <summary> 
        /// Returns the corresponding vector to the given angle (in radians).
        /// <param name="magnitude"> Desired vector magnitude. </param>
        /// </summary>
        public static Vector2 VectorFromAngleRad(this ValueType angle, float magnitude = 1f)
        {
            return new Vector2(Mathf.Cos((float) angle), Mathf.Sin((float) angle)) * magnitude;
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
            var x = Mathf.Cos((angle + v.AngleFromVectorDeg()) * Mathf.Deg2Rad) * v.magnitude;
            var y = Mathf.Sin((angle + v.AngleFromVectorDeg()) * Mathf.Deg2Rad) * v.magnitude;

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
            var x = Mathf.Cos(angle + v.AngleFromVectorRad()) * v.magnitude;
            var y = Mathf.Sin(angle + v.AngleFromVectorRad()) * v.magnitude;

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
        public static Vector3 Round(this Vector3 vector3, int decimalPlaces)
        {
            float multiplier = 1;
            for (var i = 0; i < decimalPlaces; i++) multiplier *= 10f;
            return new Vector3(
                Mathf.Round(vector3.x * multiplier) / multiplier,
                Mathf.Round(vector3.y * multiplier) / multiplier,
                Mathf.Round(vector3.z * multiplier) / multiplier);
        }

        /// <summary>
        ///     Clamps Vector3 components between provided values.
        /// </summary>
        /// <param name="vector3"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static Vector3 Clamp(this Vector3 vector3, float min, float max)
        {
            return new Vector3(
                Mathf.Clamp(vector3.x, min, max),
                Mathf.Clamp(vector3.y, min, max),
                Mathf.Clamp(vector3.z, min, max));
        }

        /// <summary>
        ///     Clamps Vector3 components between 0 and 1.
        /// </summary>
        /// <param name="vector3"></param>
        /// <returns></returns>
        public static Vector3 Clamp(this Vector3 vector3)
        {
            return new Vector3(
                Mathf.Clamp01(vector3.x),
                Mathf.Clamp01(vector3.y),
                Mathf.Clamp01(vector3.z));
        }

        /// <summary>
        ///     Rounds Vector3.
        ///     Returns Vector3Int.    
        /// </summary>
        /// <param name="vector3"></param>
        /// <returns></returns>
        public static Vector3Int Round(this Vector3 vector3)
        {
            return new Vector3Int(
                vector3.x.RoundToInt(),
                vector3.y.RoundToInt(),
                vector3.z.RoundToInt());
        }

        /// <summary>
        ///     Transforms a Vector2 to a Vector3 with Unity's (x, z) 2D coordinate system in mind.
        /// </summary>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static Vector3 TransformTo2DVector3(this Vector2 vector2)
        {
            return new Vector3(vector2.x, 0, vector2.y);
        }

        /// <summary>
        ///     Chops a Vector3 to a Vector3 with Unity's (x, z) 2D coordinate system in mind.
        /// </summary>
        /// <param name="vector3"></param>
        /// <returns></returns>
        public static Vector3 ChopTo2DVector3(this Vector3 vector3, float y = 0f)
        {
            return new Vector3(vector3.x, y, vector3.z );
        }

        /// <summary>
        ///     Rounds Vector2.
        /// </summary>
        /// <param name="vector2"></param>
        /// <param name="decimalPlaces"></param>
        /// <returns></returns>
        public static Vector2 Round(this Vector2 vector2, int decimalPlaces)
        {
            var multiplier = 1f;
            for (var i = 0; i < decimalPlaces; i++) multiplier *= 10f;
            return new Vector2(
                Mathf.Round(vector2.x * multiplier) / multiplier,
                Mathf.Round(vector2.y * multiplier) / multiplier);
        }

        /// <summary>
        ///     Rounds Vector2.
        ///     Returns Vector2Int.
        /// </summary>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static Vector2Int Round(this Vector2 vector2)
        {
            return new Vector2Int(
                vector2.x.RoundToInt(),
                vector2.y.RoundToInt());
        }

        /// <summary>
        ///     Writes the string to the Console.
        /// </summary>
        /// <param name="msg">String to be written.</param>
        /// <param name="type">Type of .</param>
        /// <returns></returns>
        public static void Print(this string msg, LogTypes type = LogTypes.Message)
        {
            switch (type)
            {
                case LogTypes.Message:
                    Debug.Log(msg);
                    break;
                case LogTypes.Warning:
                    Debug.LogWarning(msg);
                    break;
                case LogTypes.Error:
                    Debug.LogError(msg);
                    break;
            }
        }

        /// <summary>
        ///     Rounds float and returns float according to the number of decimal places supplied.
        /// </summary>
        /// <param name="numb"></param>
        /// <param name="decimalPlaces">Number of decimals after the period.</param>
        /// <returns></returns>
        public static float Round(this float numb, int decimalPlaces)
        {
            var multiplier = 1f;
            for (var i = 0; i < decimalPlaces; i++) multiplier *= 10f;
            return Mathf.Round(numb * multiplier) / multiplier;
        }
        
        /// <summary>
        ///     Rounds float and returns float.
        /// </summary>
        /// <param name="numb"></param>
        /// <returns></returns>
        public static float Round(this float numb)
        {
            return Mathf.Round(numb);
        }

        /// <summary>
        ///     Rounds float and returns int.
        /// </summary>
        /// <param name="numb"></param>
        /// <returns></returns>
        public static int RoundToInt(this float numb)
        {
            return Mathf.RoundToInt(numb);
        }

        /// <summary>
        ///     Rounds double and returns int.
        /// </summary>
        /// <param name="numb"></param>
        /// <returns></returns>
        public static int RoundToInt(this double numb)
        {
            return Mathf.RoundToInt((float) numb);
        }

        /// <summary>
        ///      Clamps float between provided values.
        /// </summary>
        /// <param name="numb"></param>
        /// <param name="min">Lower bound.</param>
        /// <param name="max">Upper bound.</param>
        /// <returns></returns>
        public static float Clamp(this float numb, float min, float max)
        {
            return Mathf.Clamp(numb, min, max);
        }

        /// <summary>
        ///      Clamps float between 0 and 1.
        /// </summary>
        /// <param name="numb"></param>
        /// <returns></returns>
        public static float Clamp(this float numb)
        {
            return Mathf.Clamp01(numb);
        }
        
        /// <summary>
        ///     Maps the supplied value and range to the desired range. <br/>
        ///     Returns -1 if supplied value is out of supplied range. <br/>
        ///     Exact function from <a href="https://forum.unity.com/threads/re-map-a-number-from-one-range-to-another.119437/#post-800377">here</a>: 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="from1">Start of range of supplied value. </param>
        /// <param name="to1">End of range of supplied value.</param>
        /// <param name="from2">Start of desired range.</param>
        /// <param name="to2">End of desired range.</param>
        /// <returns></returns>
        public static float Map (this float value, float from1, float to1, float from2, float to2)
        {

            //if (value < from1 || value > to1) return -1;
            
            return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        }

        /// <summary>
        ///     Returns the absolute value.
        /// </summary>
        /// <param name="numb"></param>
        /// <returns></returns>
        public static ValueType Abs<T>(this T numb)
        {
            try
            {
                switch (numb)
                {
                    case float f:
                        return Mathf.Abs(f);
                    case int i:
                        return Mathf.Abs(i);
                }
            }
            catch (Exception e)
            {
                e.Message.Print(LogTypes.Error);
            }

            return null;
        }
    }
}
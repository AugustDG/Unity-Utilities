using UnityEngine;

namespace Utilities.Extensions
{
    public static class GameObjectExtensions
    {
        /// <summary> 
        /// More elegant way of writing Destroy(gameObject).
        /// </summary>
        public static void Destroy(this GameObject go)
        {
            Object.Destroy(go);
        }
        
        /// <summary> 
        /// More elegant way of writing DestroyImmediate(gameObject).
        /// For use in the Editor only!
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
        /// Smoothly makes the Rigidbody2D follow the specified GameObject.
        /// Should be used in FixedUpdate (recommended).
        /// <param name="go">GameObject to follow.</param>
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
        /// Smoothly translates the GameObject up. 
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoUp(this GameObject go, float speed = 1f, Space relativeTo = Space.World)
        {
            go.transform.Translate(Vector3.up * Time.deltaTime * speed, relativeTo);
        }

        /// <summary> 
        /// Smoothly translates the GameObject down.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoDown(this GameObject go, float speed = 1f, Space relativeTo = Space.World)
        {
            go.transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);
        }

        /// <summary> 
        /// Smoothly translates the GameObject left.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoLeft(this GameObject go, float speed = 1f, Space relativeTo = Space.World)
        {
            go.transform.Translate(Vector3.left * Time.deltaTime * speed, relativeTo);
        }

        /// <summary> 
        /// Smoothly translates the GameObject right.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoRight(this GameObject go, float speed = 1f, Space relativeTo = Space.World)
        {
            go.transform.Translate(Vector3.right * Time.deltaTime * speed, relativeTo);
        }

        /// <summary> 
        /// Smoothly translates the GameObject forwards.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoForward(this GameObject go, float speed = 1f, Space relativeTo = Space.World)
        {
            go.transform.Translate(Vector3.forward * Time.deltaTime * speed, relativeTo);
        }

        /// <summary> 
        /// Smoothly translates the GameObject backwards.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoBackward(this GameObject go, float speed = 1f, Space relativeTo = Space.World)
        {
            go.transform.Translate(Vector3.back * Time.deltaTime * speed, relativeTo);
        }
        
        /// <summary> 
        /// Smoothly translates the Transform up. 
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoUp(this Transform trans, float speed = 1f, Space relativeTo = Space.World)
        {
            trans.Translate(Vector3.up * Time.deltaTime * speed, relativeTo);
        }

        /// <summary> 
        /// Smoothly translates the Transform down.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoDown(this Transform trans, float speed = 1f, Space relativeTo = Space.World)
        {
            trans.transform.Translate(Vector3.down * Time.deltaTime * speed, relativeTo);
        }

        /// <summary> 
        /// Smoothly translates the Transform left.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoLeft(this Transform trans, float speed = 1f, Space relativeTo = Space.World)
        {
            trans.transform.Translate(Vector3.left * Time.deltaTime * speed, relativeTo);
        }

        /// <summary> 
        /// Smoothly translates the Transform right.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoRight(this Transform trans, float speed = 1f, Space relativeTo = Space.World)
        {
            trans.transform.Translate(Vector3.right * Time.deltaTime * speed, relativeTo);
        }

        /// <summary> 
        /// Smoothly translates the Transform forwards.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoForward(this Transform trans, float speed = 1f, Space relativeTo = Space.World)
        {
            trans.transform.Translate(Vector3.forward * Time.deltaTime * speed, relativeTo);
        }

        /// <summary> 
        /// Smoothly translates the Transform backwards.
        /// <param name="speed">Speed of translation.</param>
        /// </summary>
        public static void GoBackward(this Transform trans, float speed = 1f, Space relativeTo = Space.World)
        {
            trans.transform.Translate(Vector3.back * Time.deltaTime * speed, relativeTo);
        }
    }
}
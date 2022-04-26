// Methods come from this very helpful post: https://forum.unity.com/threads/average-quaternions.86898/

using UnityEngine;

namespace UnityUtilities.Extensions
{

    public static class QuaternionExtensions
    {
        /// <summary>
        /// Get an average (mean) from more than two quaternions (with two, slerp would be used).
        /// </summary>
        /// <remarks>
        /// This only works if all the quaternions are relatively close together.
        /// </remarks>
        /// <param name="cumulative">External Vector4 which holds all the added x, y, z and w components.</param>
        /// <param name="newRotation">Next rotation to be added to the average pool.</param>
        /// <param name="firstRotation">First quaternion of the array to be averaged.</param>
        /// <param name="addAmount">Total amount of quaternions which are currently added.</param>
        /// <returns>Current average quaternion</returns>
        public static Quaternion AverageQuaternions(ref Vector4 cumulative, Quaternion newRotation, Quaternion firstRotation, int addAmount)
        {
            //Before we add the new rotation to the average (mean), we have to check whether the quaternion has to be inverted. Because
            //q and -q are the same rotation, but cannot be averaged, we have to make sure they are all the same.
            if (!newRotation.IsClose(firstRotation)) newRotation.InverseSign();

            var avgQ = new Quaternion();
            
            //Average the values
            var addDet = 1f / addAmount;
            cumulative.w += newRotation.w;
            avgQ.w = cumulative.w * addDet;
            cumulative.x += newRotation.x;
            avgQ.x = cumulative.x * addDet;
            cumulative.y += newRotation.y;
            avgQ.y = cumulative.y * addDet;
            cumulative.z += newRotation.z;
            avgQ.z = cumulative.z * addDet;

            //note: if speed is an issue, you can skip the normalization step. it's to make sure they're normalized, even if they should be!
            //see this: https://gamedev.net/forums/topic/429146-why-normalize-quaternions/3854543/ for more information.
            avgQ.Normalize();

            return avgQ;
        }

        /// <summary>
        /// Get an average (mean) from more than two quaternions (with two, slerp would be used). It's the method's fast version, as it does not normalize the result.
        /// </summary>
        /// <remarks>
        /// This only works if all the quaternions are relatively close together.
        /// </remarks>
        /// <param name="cumulative">External Vector4 which holds all the added x, y, z and w components.</param>
        /// <param name="newRotation">Next rotation to be added to the average pool.</param>
        /// <param name="firstRotation">First quaternion of the array to be averaged.</param>
        /// <param name="addAmount">Total amount of quaternions which are currently added.</param>
        /// <returns>Current average quaternion</returns>
        public static Quaternion AverageQuaternionsFast(ref Vector4 cumulative, Quaternion newRotation, Quaternion firstRotation, int addAmount)
        {
            //Before we add the new rotation to the average (mean), we have to check whether the quaternion has to be inverted. Because
            //q and -q are the same rotation, but cannot be averaged, we have to make sure they are all the same.
            if (!newRotation.IsClose(firstRotation)) newRotation.InverseSign();

            //Average the values
            var avgQ = new Quaternion();
            
            //Average the values
            var addDet = 1f / addAmount;
            cumulative.w += newRotation.w;
            avgQ.w = cumulative.w * addDet;
            cumulative.x += newRotation.x;
            avgQ.x = cumulative.x * addDet;
            cumulative.y += newRotation.y;
            avgQ.y = cumulative.y * addDet;
            cumulative.z += newRotation.z;
            avgQ.z = cumulative.z * addDet;
            
            return avgQ;
        }

        /// <summary>
        /// Normalizes a quaternion.
        /// </summary>
        /// <param name="q">Quaternion to be normalized.</param>
        /// <returns>Normalized quaternion.</returns>
        public static void Normalize(this ref Quaternion q)
        {
            var lengthD = 1.0f / (q.w * q.w + q.x * q.x + q.y * q.y + q.z * q.z);

            q.Scale(lengthD);
        }

        /// <summary>
        /// Changes the sign of the quaternion components. This is not the same as the inverse.
        /// </summary>
        /// <param name="q">Quaternion to inverse</param>
        public static void InverseSign(this ref Quaternion q)
        {
            q = new Quaternion(-q.x, -q.y, -q.z, -q.w);
        }


        /// <summary>
        /// Can be used to check whether or not one of two quaternions which are supposed to be very similar but has its component signs reversed (q has the same rotation as -q).
        /// </summary>
        /// <param name="q1">First quaternion to check.</param>
        /// <param name="q2">Second quaternion to check.</param>
        /// <returns>True if the two input quaternions are close to each other</returns>
        public static bool IsClose(this Quaternion q1, Quaternion q2)
        {
            var dot = Quaternion.Dot(q1, q2);

            if (dot < 0.0f)
                return false;
            else
                return true;
        }
        
        /// <summary>
        /// Multiplies this quaternion with the given scalar.
        /// </summary>
        /// <param name="q">Quaternion to scale.</param>
        /// <param name="amount">Scalar to use.</param>
        public static void Scale(this ref Quaternion q, float amount)
        {
            q.w *= amount;
            q.x *= amount;
            q.y *= amount;
            q.z *= amount;
        }
    }
}
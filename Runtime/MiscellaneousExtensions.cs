using UnityEngine;
using UnityUtilities.Misc;

namespace UnityUtilities.Extensions
{
    public static class MiscellaneousExtensions
    {
        /// <summary>
        /// Flips a 2-big float array, so that the values swap indexes.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Flipped array</returns>
        public static float[] Flip(this float[] array)
        {
            if (array.Length != 2) return array;

            return new []{array[1], array[0]};
        }
    }
}
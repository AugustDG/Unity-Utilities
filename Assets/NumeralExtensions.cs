using UnityEngine;

namespace UnityUtilities.Extensions
{
    public static class NumeralExtensions
    {
        /// <summary>
        ///     Rounds float and returns float. Use this if the number of decimals don't matter and you want to minimize overhead.
        /// </summary>
        /// <param name="numb"></param>
        /// <returns>Rounded float</returns>
        public static float Round(this float numb)
        {
            return Mathf.Round(numb);
        }
        
        /// <summary>
        ///     Rounds float and returns float according to the number of decimal places supplied.
        /// </summary>
        /// <param name="numb"></param>
        /// <param name="decimalPlaces">Number of decimals after the period.</param>
        /// <returns>Rounded float</returns>
        public static float Round(this float numb, int decimalPlaces)
        {
            var multiplier = 1f;
            for (var i = 0; i < decimalPlaces; i++) multiplier *= 10f;
            return Mathf.Round(numb * multiplier) / multiplier;
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
        ///      Clamps float between provided values.
        /// </summary>
        /// <param name="numb"></param>
        /// <param name="min">Lower bound.</param>
        /// <param name="max">Upper bound.</param>
        /// <returns>Clamped float</returns>
        public static float Clamp(this float numb, float min, float max)
        {
            return Mathf.Clamp(numb, min, max);
        }

        /// <summary>
        ///      Clamps float between 0 and 1.
        /// </summary>
        /// <param name="numb"></param>
        /// <returns>Clamped float</returns>
        public static float Clamp(this float numb)
        {
            return Mathf.Clamp01(numb);
        }

        /// <summary>
        ///     Returns the absolute value.
        /// </summary>
        /// <param name="numb"></param>
        /// <returns>Absolute value</returns>
        public static float Abs(this float numb)
        {
            return Mathf.Abs(numb);
        }
        
        /// <summary>
        ///     Returns the absolute value.
        /// </summary>
        /// <param name="numb"></param>
        /// <returns>Absolute value</returns>
        public static int Abs(this int numb)
        {
            return Mathf.Abs(numb);
        }
        
        /// <summary>
        ///     Maps the supplied value and range to the desired range for (floats). <br/>
        ///     Returns -1 if supplied value is out of supplied range. <br/>
        ///     Exact function from <a href="https://forum.unity.com/threads/re-map-a-number-from-one-range-to-another.119437/#post-800377">here</a>. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="from1">Start of range of supplied value. </param>
        /// <param name="to1">End of range of supplied value.</param>
        /// <param name="from2">Start of desired range.</param>
        /// <param name="to2">End of desired range.</param>
        /// <returns></returns>
        public static float Map (this float value, float from1, float to1, float from2, float to2)
        {
            return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        }
        
        /// <summary>
        ///     Maps the supplied value and range to the desired range (for ints). <br/>
        ///     Returns -1 if supplied value is out of supplied range. <br/>
        ///     Exact function from <a href="https://forum.unity.com/threads/re-map-a-number-from-one-range-to-another.119437/#post-800377">here</a>. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="from1">Start of range of supplied value. </param>
        /// <param name="to1">End of range of supplied value.</param>
        /// <param name="from2">Start of desired range.</param>
        /// <param name="to2">End of desired range.</param>
        /// <returns></returns>
        public static int Map (this int value, int from1, int to1, int from2, int to2)
        {
            return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        }
    }
}
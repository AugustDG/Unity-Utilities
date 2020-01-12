using System;
using JetBrains.Annotations;
using UnityEngine;
using Utilities.Exceptions;

namespace Utilities.Extensions
{
    enum LogTypes
    {
        Message,
        Warning,
        Error
    }
    
    internal static class CsExtensions
    {
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
        ///     Rounds float and returns int.
        /// </summary>
        /// <param name="numb"></param>
        /// <param name="decimalPlaces"></param>
        /// <returns></returns>
        public static int Round(this float numb, int decimalPlaces = 2)
        {
            return Mathf.RoundToInt(numb);
        }

        /// <summary>
        ///     Returns the absolute value.
        /// </summary>
        /// <param name="numb"></param>
        /// <returns></returns>
        public static ValueType Abs<T>([NotNull] this T numb)
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
            catch(Exception e)
            {
                e.Message.Print(LogTypes.Error);
            }
            
            return null;
        }
    }
}
using UnityEngine;

namespace UnityUtilities.Extensions
{
    /// <summary>
    /// A custom MonoBehaviour, extending the basic MonoBehaviour.
    /// </summary>
    public class CustomBehaviour : MonoBehaviour
    {
        /// <summary>
        /// Logs a message to the console with the object's name.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        public void Log(object message) => Debug.Log(GetType().Name + $": {message}");

        /// <summary>
        /// Logs a message to the console with the object's name.
        /// </summary>
        /// <param name="caller">Object calling the logger.</param>
        /// <param name="message">Message to be logged.</param>
        public static void Log(object caller, object message) => Debug.Log(caller.GetType().Name + $": {message}");
        
        /// <summary>
        /// Logs a warning to the console with the object's name.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        public void LogWarning(object message) => Debug.LogWarning(GetType().Name + $": {message}");
        
        /// <summary>
        /// Logs a warning to the console with the object's name.
        /// </summary>
        /// <param name="caller">Object calling the logger.</param>
        /// <param name="message">Message to be logged.</param>
        public static void LogWarning(object caller, object message) => Debug.LogWarning(caller.GetType().Name + $": {message}");
        
        /// <summary>
        /// Logs an error to the console with the object's name.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        public void LogError(object message) => Debug.LogError(GetType().Name + $": {message}");
        
        /// <summary>
        /// Logs an error to the console with the object's name.
        /// </summary>
        /// <param name="caller">Object calling the logger.</param>
        /// <param name="message">Message to be logged.</param>
        public static void LogError(object caller, object message) => Debug.LogError(caller.GetType().Name + $": {message}");
    }
}
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
        protected void Log(object message) => Debug.Log(GetType().Name + $": {message}");
        
        /// <summary>
        /// Logs a warning to the console with the object's name.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        protected void LogWarning(object message) => Debug.LogWarning(GetType().Name + $": {message}");
        
        /// <summary>
        /// Logs an error to the console with the object's name.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        protected void LogError(object message) => Debug.LogError(GetType().Name + $": {message}");
    }
}
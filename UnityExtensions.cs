using System;
using System.Collections;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UnityUtilities.Extensions
{
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
        ///     Writes the string to the Console.
        /// </summary>
        /// <param name="msg">String to be written.</param>
        /// <param name="type">Type of .</param>
        /// <returns></returns>
        public static void Print(this string msg, LogType type = LogType.Log)
        {
            switch (type)
            {
                case LogType.Log:
                    Debug.Log(msg);
                    break;
                case LogType.Warning:
                    Debug.LogWarning(msg);
                    break;
                case LogType.Exception:
                case LogType.Error:
                    Debug.LogError(msg);
                    break;
                case LogType.Assert:
                    Debug.LogAssertion(msg);
                    break;
            }
        }
    }
}
using System;
using System.Collections;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UnityUtilities.Extensions
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
        /// Delays action by specified number of seconds.
        /// <param name="monoBehaviour"><see cref="MonoBehaviour"/> to piggyback the <see cref="Coroutine"/> from.</param>
        /// <param name="delayedAction">Action to call after delay.</param>
        /// <param name="timeInSec">How many realtime seconds will be waiting.</param>
        /// </summary>
        public static Coroutine DelayAction(MonoBehaviour monoBehaviour, Action delayedAction, float timeInSec)
        {
            IEnumerator DelayActionRoutine()
            {
                yield return new WaitForSecondsRealtime(timeInSec);
            
                delayedAction.Invoke();
            }

            return monoBehaviour.StartCoroutine(DelayActionRoutine());
        }
        
        /// <summary>
        /// Checks if the animator is currently playing an animation.
        /// See this <a href="https://answers.unity.com/questions/362629/how-can-i-check-if-an-animation-is-being-played-or.html">Unity Forum</a> post for more information.
        /// </summary>
        /// <param name="animator">Animator to be checked.</param>
        /// <returns>True if it's playing; false otherwise.</returns>
        public static bool IsAnimatorPlaying(this Animator animator)
        {
            return animator.GetCurrentAnimatorStateInfo(0).length >
                animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
        }

        /// <summary>
        /// Writes the object to the Debug Console.
        /// </summary>
        /// <param name="msg">Object to be logged.</param>
        /// <param name="type">Type of log.</param>
        /// <returns></returns>
        public static void Print(this object msg, LogType type = LogType.Log)
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
using System;
using System.Collections;
using UnityEngine;

namespace Extensions
{
    public class Coroutines
    {
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
    }
}
using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Extensions
{
    /// <summary>
    /// Suspends the coroutine execution for the given amount of seconds using unscaled time and while the passed condition is true.
    /// </summary>
    public class WaitWhileAndForSecondsRealtime : CustomYieldInstruction
    {
        public WaitForSecondsRealtime WaitForSecondsRealtime { get; }
        public WaitWhile WaitWhile { get; }

        public override bool keepWaiting => WaitForSecondsRealtime.keepWaiting || WaitWhile.keepWaiting;
        
        public WaitWhileAndForSecondsRealtime(WaitWhile waitWhile, WaitForSecondsRealtime waitForSecondsRealtime)
        {
            WaitWhile = waitWhile;
            WaitForSecondsRealtime = waitForSecondsRealtime;
        }
        
        public WaitWhileAndForSecondsRealtime(Func<bool> waitWhilePredicate, float waitForSecondsRealtimeTime) : this(new WaitWhile(waitWhilePredicate), new WaitForSecondsRealtime(waitForSecondsRealtimeTime)){}
    }
}
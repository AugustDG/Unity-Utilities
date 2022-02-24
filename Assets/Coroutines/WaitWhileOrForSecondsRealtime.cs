using System;
using UnityEngine;

namespace Extensions
{
    /// <summary>
    /// Suspends the coroutine execution for the given amount of seconds using unscaled time or while the passed condition is true.
    /// </summary>
    public class WaitWhileOrForSecondsRealtime : CustomYieldInstruction
    {
        public WaitForSecondsRealtime WaitForSecondsRealtime { get; }
        public WaitWhile WaitWhile { get; }

        public override bool keepWaiting => WaitForSecondsRealtime.keepWaiting || WaitWhile.keepWaiting;

        public WaitWhileOrForSecondsRealtime(WaitWhile waitWhile, WaitForSecondsRealtime waitForSecondsRealtime)
        {
            WaitWhile = waitWhile;
            WaitForSecondsRealtime = waitForSecondsRealtime;
        }
        
        public WaitWhileOrForSecondsRealtime(Func<bool> waitWhilePredicate, float waitForSecondsRealtimeTime) : this(new WaitWhile(waitWhilePredicate), new WaitForSecondsRealtime(waitForSecondsRealtimeTime)){}
    }
}
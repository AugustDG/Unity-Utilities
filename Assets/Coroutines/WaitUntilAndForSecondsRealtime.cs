using System;
using UnityEngine;

namespace Extensions
{
    /// <summary>
    /// Suspends the coroutine execution for the given amount of seconds using unscaled time and until the passed condition is true.
    /// </summary>
    public class WaitUntilAndForSecondsRealtime : CustomYieldInstruction
    {
        public WaitForSecondsRealtime WaitForSecondsRealtime { get; }
        public WaitUntil WaitUntil { get; }

        public override bool keepWaiting => WaitForSecondsRealtime.keepWaiting || WaitUntil.keepWaiting;

        public WaitUntilAndForSecondsRealtime(WaitUntil waitUntil, WaitForSecondsRealtime waitForSecondsRealtime)
        {
            WaitUntil = waitUntil;
            WaitForSecondsRealtime = waitForSecondsRealtime;
        }
        
        public WaitUntilAndForSecondsRealtime(Func<bool> waitUntilPredicate, float waitForSecondsRealtimeTime) : this(new WaitUntil(waitUntilPredicate), new WaitForSecondsRealtime(waitForSecondsRealtimeTime)){}
    }
}
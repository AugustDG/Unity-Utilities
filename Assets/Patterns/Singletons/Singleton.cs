using UnityEngine;

namespace UnityUtilities.Extensions.Patterns
{
    /// <summary>
    /// Generic singleton class, made for <see cref="MonoBehaviour">MonoBehaviours</see>.
    /// If <see cref="Instance"/> is null, this object is assigned; if it's not equal to this object, destroy this object. Does not survive scene loading and if <see cref="Instance"/> does not exist, won't be created!
    /// </summary>
    /// <remarks>Inheriting classes must call base.Awake() if overriding Awake!</remarks>
    /// <typeparam name="T">Type.</typeparam>
    public abstract class Singleton<T> : MonoBehaviour where T : Component
    {
        /// <summary>
        /// Static instance.
        /// </summary>
        public static T Instance { get; private set;}

        protected virtual void Awake()
        {
            if ( Instance == null)
            {
                Instance = this as T;
            }
            else if (Instance != this as T)
            {
                gameObject.Destroy();
            }
        }
    }
}
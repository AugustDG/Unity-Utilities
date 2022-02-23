using UnityEngine;

namespace UnityUtilities.Extensions.Patterns
{
    /// <summary>
    /// Generic singleton class, made for <see cref="MonoBehaviour">MonoBehaviours</see>.
    /// If <see cref="Instance"/> is null, this object is assigned; if it's not equal to this object, destroy this object. Does not survive scene loading and if <see cref="Instance"/> does not exist, won't be created!
    /// </summary>
    /// <remarks>Inheriting classes must call base.Awake() if overriding Awake!</remarks>
    /// <typeparam name="T">Type.</typeparam>
    public abstract class Singleton<T> : MonoBehaviour
    {
        /// <summary>
        /// Static instance.
        /// </summary>
        public static Singleton<T> Instance => _instance;
        private static Singleton<T> _instance;
        
        protected virtual void Awake()
        {
            if ( _instance == null)
            {
                _instance = this;
            }
            else if (_instance != this)
            {
                gameObject.Destroy();
            }
        }
    }
}
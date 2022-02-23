using UnityEngine;

namespace UnityUtilities.Extensions.Patterns
{
    /// <summary>
    /// Generic lazy singleton class, made for <see cref="MonoBehaviour">MonoBehaviours</see>.
    /// Survives scene loading and if <see cref="Instance"/> is invalid, then <see cref="Instance"/> will be created!
    /// </summary>
    /// <remarks>Inheriting classes must call base.Awake() if overriding Awake!</remarks>
    /// <typeparam name="T">Type.</typeparam>
    public abstract class SingletonLazy<T> : MonoBehaviour
    {
        /// <summary>
        /// Static instance.
        /// </summary>
        public static SingletonLazy<T> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Instantiate( new GameObject(nameof(T)).AddComponent<SingletonLazy<T>>(), Vector3.zero, Quaternion.identity);
                }

                return _instance;
            }    
        }
        
        private static SingletonLazy<T> _instance;

        protected virtual void Awake()
        {
            if (_instance != this)
            {
                gameObject.Destroy();
            }
            else
            {
                DontDestroyOnLoad(this);
            }
        }
    }
}
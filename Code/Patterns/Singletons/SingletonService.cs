namespace UnityUtilities.Extensions.Patterns
{
    /// <summary>
    /// Generic singleton-style class, for public parameterless <see cref="T"/> constructor's classes.
    /// A C# only singleton (does not interact with Unity), mainly used for services.
    /// When inheriting, create static methods to interact with the service; keep all properties and variables as private, non-static and fetch them from <see cref="Instance"/>! See example and link below for more info:
    /// <code>
    /// <![CDATA[
    /// public class ServiceOne : SingletonService<ServiceOne>
    /// {
    ///     private int _number = 23 
    ///     public ServiceOne() { }
    ///     public static int GetSomething()
    ///     {
    ///         return Instance._number;
    ///     }
    /// }]]>
    /// </code>
    /// Check out this <a href="https://answers.unity.com/questions/1392720/which-singleton-design-pattern-should-be-used.html">Unity Forum</a> post!
    /// </summary>
    /// <typeparam name="T">Type.</typeparam>
    public abstract class SingletonService<T> where T: new()
    {
        /// <summary>
        /// Static instance.
        /// </summary>
        protected static T Instance => _backingInstance ??= new T();
        private static T _backingInstance;
    }
}
﻿namespace Reflection4Net.Accessor
{
    /// <summary>
    /// Provides the capability to create IPropertyAccessor instance according to Class or Instance.
    /// </summary>
    public interface IAccessorFactory
    {
        /// <summary>
        /// Gets an IPropertyAccessor by an object.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>An instance of IPropertyAdapter.</returns>
        IDynamicPropertyAccessor GetAccessor(object value);

        /// <summary>
        /// Gets an IPropertyAccessor by a Type.
        /// </summary>
        /// <typeparam name="T">The generic type to get IPropertyAccessor from.</typeparam>
        /// <returns>An instance of IPropertyAccessor.</returns>
        IDynamicPropertyAccessor GetAccessor<T>();
    }
}

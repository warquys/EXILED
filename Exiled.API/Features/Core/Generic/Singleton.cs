// -----------------------------------------------------------------------
// <copyright file="Singleton.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Features.Core.Generic
{
    /// <summary>
    /// A class to handle object instances.
    /// </summary>
    /// <typeparam name="T">The type of the object to handle the instance of.</typeparam>
    public static class Singleton<T>
        where T : class
    {
        /// <summary>
        /// Gets the relative value.
        /// </summary>
        public static T Instance { get; private set; }

        /// <summary>
        /// Tries to get the relative value.
        /// </summary>
        /// <param name="instance">The object instance.</param>
        /// <returns><see langword="true"/> if the object instance is not null and can be casted as the specified type; otherwise, <see langword="false"/>.</returns>
        public static bool TryGet(out T instance)
            => (instance = Instance) is not null;

        /// <summary>
        /// Tries to get the relative value.
        /// If you whant to repalce <see cref="Instance"/> first call <see cref="Destroy()"/>.
        /// </summary>
        /// <param name="object">The object use to create the singleton.</param>
        public static void Create(T @object)
        {
            if (Instance is not null)
               return;
            Instance = @object;
        }

        /// <summary>
        /// Set to null <see cref="Instance"/> if <paramref name="object"/> is the same.
        /// </summary>
        /// <param name="object">The object to destroy.</param>
        /// <returns><see langword="true"/> if the instance was destroyed; otherwise, <see langword="false"/>.</returns>
        public static bool Destroy(T @object)
        {
            if (Instance == @object)
            {
                Instance = null;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Set to null <see cref="Instance"/>.
        /// </summary>
        public static void Destroy()
        {
            Instance = null;
        }
    }
}
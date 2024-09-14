using UnityEngine;

namespace Exiled.API.Features.Core.Interfaces
{
    /// <summary>
    /// Define a self-getter method.
    /// </summary>
    /// <typeparam name="TSelf">
    /// The type implementing the self-getter.
    /// </typeparam>
    public interface IGameObjectGet<out TSelf>
        where TSelf : IGameObjectGet<TSelf>
    {
        /// <summary>
        /// Return an instance of the implementing type base on a given gameObject.
        /// </summary>
        /// <param name="gameObject">
        /// The gameObject to get the instance from.
        /// </param>
        /// <returns>
        /// The instance of the implementing type.
        /// </returns>
        public static abstract TSelf Get(GameObject gameObject);
    }
}

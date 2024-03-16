using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyStack.DotNet.Redis.Abstractions
{
    public interface IRedisService
    {
        /// <summary>
        /// Gets an item from the cache
        /// </summary>
        /// <typeparam name="T">The type of item to get</typeparam>
        /// <param name="key">The key of item to get from</param>
        /// <returns>The instance of the item as stored in Redis</returns>
        T GetItem <T>(string key);

        T GetItemProperty<T>(string key, MemberExpression propertyExpression);

        /// <summary>
        /// Stores an item in the cache
        /// </summary>
        /// <typeparam name="T">The type of the item to store</typeparam>
        /// <param name="key">The key to store the item under in Redis</param>
        /// <param name="value">The value to be stored in Redis under the given Key</param>
        void SetItem<T>(string key, T value);

        void SetItemProperty<T>(string key, MemberExpression propertyExpression, T value);

        /// <summary>
        /// Stores an item in the cache
        /// </summary>
        /// <typeparam name="T">The type of the item to store</typeparam>
        /// <param name="key">The key to store the item under in Redis</param>
        /// <param name="value">The value to be stored in Redis under the given Key</param>
        /// <param name="expiration">The time interval in which the stored cache item will be deleted automatically by Redis</param>
        void SetItem<T>(string key, T value, TimeSpan expiration);

        /// <summary>
        /// Removes an item from the cache
        /// </summary>
        /// <param name="key">The key to be removed from Redis</param>
        void RemoveItem(string key);




    }
}

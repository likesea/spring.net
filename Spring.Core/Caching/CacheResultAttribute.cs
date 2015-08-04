#region License

/*
 * Copyright 2002-2010 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System;

namespace Spring.Caching
{
    /// <summary>
    /// This attribute should be used to mark methods whose result 
    /// needs to be cached.
    /// </summary>
    /// <remarks>
    /// <p>
    /// This attribute allows application developers to mark that a result 
    /// of the method invocation should be cached, but it will not do any
    /// caching by itself.
    /// </p>
    /// <p>
    /// In order to actually cache the result, an application developer
    /// must apply a <c>Spring.Aspects.Cache.CacheResultAdvice</c> to
    /// all of the members that have this attribute defined.
    /// </p>
    /// </remarks>
    /// <author>Aleksandar Seovic</author>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    [Serializable]
    public sealed class CacheResultAttribute : BaseCacheAttribute
    {
        /// <summary>
        /// Creates an attribute instance.
        /// </summary>
        public CacheResultAttribute()
        {
        }

        /// <summary>
        /// Creates an attribute instance.
        /// </summary>
        /// <param name="cacheName">
        /// The name of the cache to use.
        /// </param>
        /// <param name="key">
        /// An expression string that should be evaluated in order to determine
        /// the cache key for the item.
        /// </param>
        public CacheResultAttribute(string cacheName, string key)
            : base(cacheName, key)
        {
        }
    }
}
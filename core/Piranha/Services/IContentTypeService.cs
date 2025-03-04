﻿/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System.Collections.Generic;
using System.Threading.Tasks;
using Piranha.Models;

namespace Piranha.Services
{
    public interface IContentTypeService
    {
        /// <summary>
        /// Gets all available models.
        /// </summary>
        /// <returns>The available models</returns>
        Task<IEnumerable<ContentType>> GetAllAsync();

        /// <summary>
        /// Gets the model with the specified id.
        /// </summary>
        /// <param name="id">The unique id</param>
        /// <returns>The model</returns>
        Task<ContentType> GetByIdAsync(string id);

        /// <summary>
        /// Gets all available models from the specified group.
        /// </summary>
        /// <param name="group">The content group</param>
        /// <returns>The available models</returns>
        Task<IEnumerable<ContentType>> GetByGroupAsync(string group);

        /// <summary>
        /// Adds or updates the given model in the database
        /// depending on its state.
        /// </summary>
        /// <param name="model">The model</param>
        Task SaveAsync(ContentType model);

        /// <summary>
        /// Deletes the model with the specified id.
        /// </summary>
        /// <param name="id">The unique id</param>
        Task DeleteAsync(string id);

        /// <summary>
        /// Deletes the given model.
        /// </summary>
        /// <param name="model">The model</param>
        Task DeleteAsync(ContentType model);

        /// <summary>
        /// Deletes the given models.
        /// </summary>
        /// <param name="models">The models</param>
        Task DeleteAsync(IEnumerable<ContentType> models);
    }
}

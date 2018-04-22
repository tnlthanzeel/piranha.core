/*
 * Copyright (c) 2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

using System;
using System.Collections.Generic;

namespace Piranha.Data
{
    /// <summary>
    /// Reusable content block.
    /// </summary>
    public sealed class Block : IModel, ICreated, IModified
    {
        /// <summary>
        /// Gets/sets the unique id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets/sets the CLR type of the block.
        /// </summary>
        public string CLRType { get; set; }

        /// <summary>
        /// Gets/sets the optional title. This property
        /// is only used for reusable blocks within the
        /// block library.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets/sets if this is a reusable block.
        /// </summary>
        public bool IsReusable { get; set; }

        /// <summary>
        /// Gets/sets the created date.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets/sets the last modification date.
        /// </summary>
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Gets/sets the available fields.
        /// </summary>
        public IList<BlockField> Fields { get; set; }

        /// <summary>
        /// Gets/sets the available page connections.
        /// </summary>
        public IList<PageBlock> PageBlocks { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Block() {
            Fields = new List<BlockField>();
            PageBlocks = new List<PageBlock>();
        }
    }
}

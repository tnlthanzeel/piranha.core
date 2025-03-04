/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using Microsoft.EntityFrameworkCore;

namespace Piranha.Data.EF.SQLite
{
    [NoCoverage]
    public sealed class SQLiteDb : Db<SQLiteDb>
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="options">Configuration options</param>
        public SQLiteDb(DbContextOptions<SQLiteDb> options) : base(options)
        {
        }
    }
}
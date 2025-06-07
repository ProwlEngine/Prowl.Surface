// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Prowl.Surface;

/// <summary>
/// A list of file paths to be transferred.
/// </summary>
public sealed class FileTransferList : List<string>
{
    /// <summary>
    /// Creates a new <see cref="FileTransferList"/> instance.
    /// </summary>
    public FileTransferList()
    {
        Id = Guid.NewGuid();
    }

    /// <summary>
    /// A Guid associated with this transfer.
    /// </summary>
    public Guid Id { get; internal set; }

    /// <summary>
    /// The effect associated with this list of files (e.g cut or copy or move or link).
    /// </summary>
    public DataTransferEffects PreferredDataTransferEffects { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.Append(nameof(FileTransferList)).Append(" { ");

        builder.Append(nameof(Id)).Append(" = ").Append(Id.ToString("D"));
        builder.Append(", ");
        builder.Append(nameof(PreferredDataTransferEffects)).Append(" = ").Append(PreferredDataTransferEffects.ToString());
        builder.Append(", ");
        builder.Append("Items = [ ");
        for (var i = 0; i < this.Count; i++)
        {
            var item = this[i];
            if (i > 0) builder.Append(", ");
            builder.Append(item.Replace("\"", "\\\""));
        }
        builder.Append(" ] ");

        builder.Append(" } ");
        return builder.ToString();
    }
}

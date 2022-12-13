﻿// <copyright file="ISupportCustomConfiguration.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.PlugIns;

/// <summary>
/// Interface for a plugin which has a custom configuration, which should be saved in a <see cref="PlugInConfiguration.CustomConfiguration"/>.
/// </summary>
/// <typeparam name="TCustomConfig">The type of the custom configuration.</typeparam>
public interface ISupportCustomConfiguration<TCustomConfig>
    where TCustomConfig : class
{
    /// <summary>
    /// Gets or sets the configuration.
    /// </summary>
    TCustomConfig? Configuration { get; set; }
}

/// <summary>
/// Interface for a plugin which provides a method to create a default configuration which should be saved in <see cref="PlugInConfiguration.CustomConfiguration"/>.
/// </summary>
public interface ISupportDefaultCustomConfiguration
{
    /// <summary>
    /// Creates the default configuration.
    /// </summary>
    /// <returns>The default configuration.</returns>
    object CreateDefaultConfig();
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    internal static partial class MinimumTlsVersionExtensions
    {
        public static string ToSerialString(this MinimumTlsVersion value) => value switch
        {
            MinimumTlsVersion.None => "None",
            MinimumTlsVersion.TLS10 => "TLS10",
            MinimumTlsVersion.TLS12 => "TLS12",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MinimumTlsVersion value.")
        };

        public static MinimumTlsVersion ToMinimumTlsVersion(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return MinimumTlsVersion.None;
            if (string.Equals(value, "TLS10", StringComparison.InvariantCultureIgnoreCase)) return MinimumTlsVersion.TLS10;
            if (string.Equals(value, "TLS12", StringComparison.InvariantCultureIgnoreCase)) return MinimumTlsVersion.TLS12;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MinimumTlsVersion value.");
        }
    }
}

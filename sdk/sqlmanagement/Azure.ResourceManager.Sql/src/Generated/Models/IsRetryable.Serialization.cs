// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class IsRetryableExtensions
    {
        public static string ToSerialString(this IsRetryable value) => value switch
        {
            IsRetryable.Yes => "Yes",
            IsRetryable.No => "No",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IsRetryable value.")
        };

        public static IsRetryable ToIsRetryable(this string value)
        {
            if (string.Equals(value, "Yes", StringComparison.InvariantCultureIgnoreCase)) return IsRetryable.Yes;
            if (string.Equals(value, "No", StringComparison.InvariantCultureIgnoreCase)) return IsRetryable.No;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IsRetryable value.");
        }
    }
}

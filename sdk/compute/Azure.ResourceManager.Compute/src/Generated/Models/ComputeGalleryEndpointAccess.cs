// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This property allows you to specify if the requests will be allowed to access the host endpoints. Possible values are: 'Allow', 'Deny'. </summary>
    public readonly partial struct ComputeGalleryEndpointAccess : IEquatable<ComputeGalleryEndpointAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeGalleryEndpointAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeGalleryEndpointAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> Allow. </summary>
        public static ComputeGalleryEndpointAccess Allow { get; } = new ComputeGalleryEndpointAccess(AllowValue);
        /// <summary> Deny. </summary>
        public static ComputeGalleryEndpointAccess Deny { get; } = new ComputeGalleryEndpointAccess(DenyValue);
        /// <summary> Determines if two <see cref="ComputeGalleryEndpointAccess"/> values are the same. </summary>
        public static bool operator ==(ComputeGalleryEndpointAccess left, ComputeGalleryEndpointAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeGalleryEndpointAccess"/> values are not the same. </summary>
        public static bool operator !=(ComputeGalleryEndpointAccess left, ComputeGalleryEndpointAccess right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ComputeGalleryEndpointAccess"/>. </summary>
        public static implicit operator ComputeGalleryEndpointAccess(string value) => new ComputeGalleryEndpointAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeGalleryEndpointAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeGalleryEndpointAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PlaywrightTesting.Models
{
    /// <summary> Possible reasons for a name not being available. </summary>
    public readonly partial struct PlaywrightTestingNameUnavailableReason : IEquatable<PlaywrightTestingNameUnavailableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PlaywrightTestingNameUnavailableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PlaywrightTestingNameUnavailableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Name is invalid. </summary>
        public static PlaywrightTestingNameUnavailableReason Invalid { get; } = new PlaywrightTestingNameUnavailableReason(InvalidValue);
        /// <summary> Name already exists. </summary>
        public static PlaywrightTestingNameUnavailableReason AlreadyExists { get; } = new PlaywrightTestingNameUnavailableReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="PlaywrightTestingNameUnavailableReason"/> values are the same. </summary>
        public static bool operator ==(PlaywrightTestingNameUnavailableReason left, PlaywrightTestingNameUnavailableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PlaywrightTestingNameUnavailableReason"/> values are not the same. </summary>
        public static bool operator !=(PlaywrightTestingNameUnavailableReason left, PlaywrightTestingNameUnavailableReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PlaywrightTestingNameUnavailableReason"/>. </summary>
        public static implicit operator PlaywrightTestingNameUnavailableReason(string value) => new PlaywrightTestingNameUnavailableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PlaywrightTestingNameUnavailableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PlaywrightTestingNameUnavailableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

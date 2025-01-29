// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> Defines the event observability mode. </summary>
    public readonly partial struct EventObservabilityMode : IEquatable<EventObservabilityMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventObservabilityMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventObservabilityMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string LogValue = "Log";

        /// <summary> No mapping to OpenTelemetry. </summary>
        public static EventObservabilityMode None { get; } = new EventObservabilityMode(NoneValue);
        /// <summary> Map as log to OpenTelemetry. </summary>
        public static EventObservabilityMode Log { get; } = new EventObservabilityMode(LogValue);
        /// <summary> Determines if two <see cref="EventObservabilityMode"/> values are the same. </summary>
        public static bool operator ==(EventObservabilityMode left, EventObservabilityMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventObservabilityMode"/> values are not the same. </summary>
        public static bool operator !=(EventObservabilityMode left, EventObservabilityMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EventObservabilityMode"/>. </summary>
        public static implicit operator EventObservabilityMode(string value) => new EventObservabilityMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventObservabilityMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventObservabilityMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

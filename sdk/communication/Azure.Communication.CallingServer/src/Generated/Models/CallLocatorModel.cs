// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The locator used for joining or taking action on a call. </summary>
    public partial class CallLocatorModel
    {
        /// <summary> Initializes a new instance of CallLocatorModel. </summary>
        public CallLocatorModel()
        {
        }

        /// <summary> The group call locator. </summary>
        public GroupCallLocatorModel GroupCallLocator { get; set; }
        /// <summary> The server call locator. </summary>
        public ServerCallLocatorModel ServerCallLocator { get; set; }
        /// <summary> The call locator type. </summary>
        public CallLocatorTypeModel? Type { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Contact Details. </summary>
    public partial class DataBoxContactDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxContactDetails"/>. </summary>
        /// <param name="contactName"> Contact name of the person. </param>
        /// <param name="phone"> Phone number of the contact person. </param>
        /// <param name="emailList"> List of Email-ids to be notified about job progress. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contactName"/>, <paramref name="phone"/> or <paramref name="emailList"/> is null. </exception>
        public DataBoxContactDetails(string contactName, string phone, IEnumerable<string> emailList)
        {
            Argument.AssertNotNull(contactName, nameof(contactName));
            Argument.AssertNotNull(phone, nameof(phone));
            Argument.AssertNotNull(emailList, nameof(emailList));

            ContactName = contactName;
            Phone = phone;
            EmailList = emailList.ToList();
            NotificationPreference = new ChangeTrackingList<NotificationPreference>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxContactDetails"/>. </summary>
        /// <param name="contactName"> Contact name of the person. </param>
        /// <param name="phone"> Phone number of the contact person. </param>
        /// <param name="phoneExtension"> Phone extension number of the contact person. </param>
        /// <param name="mobile"> Mobile number of the contact person. </param>
        /// <param name="emailList"> List of Email-ids to be notified about job progress. </param>
        /// <param name="notificationPreference"> Notification preference for a job stage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxContactDetails(string contactName, string phone, string phoneExtension, string mobile, IList<string> emailList, IList<NotificationPreference> notificationPreference, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContactName = contactName;
            Phone = phone;
            PhoneExtension = phoneExtension;
            Mobile = mobile;
            EmailList = emailList;
            NotificationPreference = notificationPreference;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxContactDetails"/> for deserialization. </summary>
        internal DataBoxContactDetails()
        {
        }

        /// <summary> Contact name of the person. </summary>
        public string ContactName { get; set; }
        /// <summary> Phone number of the contact person. </summary>
        public string Phone { get; set; }
        /// <summary> Phone extension number of the contact person. </summary>
        public string PhoneExtension { get; set; }
        /// <summary> Mobile number of the contact person. </summary>
        public string Mobile { get; set; }
        /// <summary> List of Email-ids to be notified about job progress. </summary>
        public IList<string> EmailList { get; }
        /// <summary> Notification preference for a job stage. </summary>
        public IList<NotificationPreference> NotificationPreference { get; }
    }
}

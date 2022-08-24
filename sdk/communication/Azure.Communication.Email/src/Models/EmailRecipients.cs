﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication.Email.Extensions;
using Azure.Core;

namespace Azure.Communication.Email.Models
{
    [CodeGenModel("EmailRecipients")]
    public partial class EmailRecipients
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailRecipients"/> class.
        /// </summary>
        /// <param name="to">Email to recipients.</param>
        /// <param name="cc">Email cc recipients. </param>
        /// <param name="bcc">Email bcc recipients. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="to"/> is null. </exception>
        public EmailRecipients(
            IEnumerable<EmailAddress> to,
            IEnumerable<EmailAddress> cc = null,
            IEnumerable<EmailAddress> bcc = null)
            :this(to)
        {
            if (cc != null)
            {
                CC = new ChangeTrackingList<EmailAddress>(new Optional<IList<EmailAddress>>(cc.ToList()));
            }

            if (cc != null)
            {
                BCC = new ChangeTrackingList<EmailAddress>(new Optional<IList<EmailAddress>>(bcc.ToList()));
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailRecipients"/> class.
        /// </summary>
        /// <param name="to">Email to recipient.</param>
        /// <param name="cc">Email cc recipients. </param>
        /// <param name="bcc">Email bcc recipients. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="to"/> is null. </exception>
        public EmailRecipients(
            EmailAddress to,
            IEnumerable<EmailAddress> cc = null,
            IEnumerable<EmailAddress> bcc = null)
            :this(new List<EmailAddress>() { to })
        {
            if (cc != null)
            {
                CC = new ChangeTrackingList<EmailAddress>(new Optional<IList<EmailAddress>>(cc.ToList()));
            }

            if (cc != null)
            {
                BCC = new ChangeTrackingList<EmailAddress>(new Optional<IList<EmailAddress>>(bcc.ToList()));
            }
        }

        internal void Validate()
        {
            if (To.Count == 0)
            {
                throw new ArgumentException(ErrorMessages.EmptyToRecipients);
            }

            To.Validate();

            CC.Validate();

            BCC.Validate();
        }
    }
}

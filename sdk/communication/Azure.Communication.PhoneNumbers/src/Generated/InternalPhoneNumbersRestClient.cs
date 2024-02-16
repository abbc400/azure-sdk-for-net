// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.PhoneNumbers
{
    internal partial class InternalPhoneNumbersRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of InternalPhoneNumbersRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://resourcename.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public InternalPhoneNumbersRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2023-10-01-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateListAreaCodesRequest(string twoLetterIsoCountryName, PhoneNumberType phoneNumberType, int? skip, int? maxPageSize, PhoneNumberAssignmentType? assignmentType, string locality, string administrativeDivision, string acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/availablePhoneNumbers/countries/", false);
            uri.AppendPath(twoLetterIsoCountryName, true);
            uri.AppendPath("/areaCodes", false);
            uri.AppendQuery("phoneNumberType", phoneNumberType.ToString(), true);
            if (skip != null)
            {
                uri.AppendQuery("skip", skip.Value, true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            if (assignmentType != null)
            {
                uri.AppendQuery("assignmentType", assignmentType.Value.ToString(), true);
            }
            if (locality != null)
            {
                uri.AppendQuery("locality", locality, true);
            }
            if (administrativeDivision != null)
            {
                uri.AppendQuery("administrativeDivision", administrativeDivision, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("accept-language", acceptLanguage);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateListAvailableCountriesRequest(int? skip, int? maxPageSize, string acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/availablePhoneNumbers/countries", false);
            if (skip != null)
            {
                uri.AppendQuery("skip", skip.Value, true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("accept-language", acceptLanguage);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateListAvailableLocalitiesRequest(string twoLetterIsoCountryName, int? skip, int? maxPageSize, string administrativeDivision, string acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/availablePhoneNumbers/countries/", false);
            uri.AppendPath(twoLetterIsoCountryName, true);
            uri.AppendPath("/localities", false);
            if (skip != null)
            {
                uri.AppendQuery("skip", skip.Value, true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            if (administrativeDivision != null)
            {
                uri.AppendQuery("administrativeDivision", administrativeDivision, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("accept-language", acceptLanguage);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateListOfferingsRequest(string twoLetterIsoCountryName, int? skip, int? maxPageSize, PhoneNumberType? phoneNumberType, PhoneNumberAssignmentType? assignmentType, string acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/availablePhoneNumbers/countries/", false);
            uri.AppendPath(twoLetterIsoCountryName, true);
            uri.AppendPath("/offerings", false);
            if (skip != null)
            {
                uri.AppendQuery("skip", skip.Value, true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            if (phoneNumberType != null)
            {
                uri.AppendQuery("phoneNumberType", phoneNumberType.Value.ToString(), true);
            }
            if (assignmentType != null)
            {
                uri.AppendQuery("assignmentType", assignmentType.Value.ToString(), true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("accept-language", acceptLanguage);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateSearchAvailablePhoneNumbersRequest(string twoLetterIsoCountryName, PhoneNumberSearchRequest body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/availablePhoneNumbers/countries/", false);
            uri.AppendPath(twoLetterIsoCountryName, true);
            uri.AppendPath("/:search", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="twoLetterIsoCountryName"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="body"> The phone number search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="twoLetterIsoCountryName"/> or <paramref name="body"/> is null. </exception>
        public async Task<ResponseWithHeaders<PhoneNumbersSearchAvailablePhoneNumbersHeaders>> SearchAvailablePhoneNumbersAsync(string twoLetterIsoCountryName, PhoneNumberSearchRequest body, CancellationToken cancellationToken = default)
        {
            if (twoLetterIsoCountryName == null)
            {
                throw new ArgumentNullException(nameof(twoLetterIsoCountryName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateSearchAvailablePhoneNumbersRequest(twoLetterIsoCountryName, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumbersSearchAvailablePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="twoLetterIsoCountryName"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="body"> The phone number search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="twoLetterIsoCountryName"/> or <paramref name="body"/> is null. </exception>
        public ResponseWithHeaders<PhoneNumbersSearchAvailablePhoneNumbersHeaders> SearchAvailablePhoneNumbers(string twoLetterIsoCountryName, PhoneNumberSearchRequest body, CancellationToken cancellationToken = default)
        {
            if (twoLetterIsoCountryName == null)
            {
                throw new ArgumentNullException(nameof(twoLetterIsoCountryName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateSearchAvailablePhoneNumbersRequest(twoLetterIsoCountryName, body);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumbersSearchAvailablePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSearchResultRequest(string searchId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/availablePhoneNumbers/searchResults/", false);
            uri.AppendPath(searchId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a phone number search result by search id. </summary>
        /// <param name="searchId"> The search Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchId"/> is null. </exception>
        public async Task<Response<PhoneNumberSearchResult>> GetSearchResultAsync(string searchId, CancellationToken cancellationToken = default)
        {
            if (searchId == null)
            {
                throw new ArgumentNullException(nameof(searchId));
            }

            using var message = CreateGetSearchResultRequest(searchId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PhoneNumberSearchResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PhoneNumberSearchResult.DeserializePhoneNumberSearchResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a phone number search result by search id. </summary>
        /// <param name="searchId"> The search Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchId"/> is null. </exception>
        public Response<PhoneNumberSearchResult> GetSearchResult(string searchId, CancellationToken cancellationToken = default)
        {
            if (searchId == null)
            {
                throw new ArgumentNullException(nameof(searchId));
            }

            using var message = CreateGetSearchResultRequest(searchId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PhoneNumberSearchResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PhoneNumberSearchResult.DeserializePhoneNumberSearchResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePurchasePhoneNumbersRequest(string searchId, bool? consentToNotResellNumbers)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/availablePhoneNumbers/:purchase", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new PhoneNumberPurchaseRequest()
            {
                SearchId = searchId,
                ConsentToNotResellNumbers = consentToNotResellNumbers
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Purchases phone numbers. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="consentToNotResellNumbers"> The consent to not resell numbers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<PhoneNumbersPurchasePhoneNumbersHeaders>> PurchasePhoneNumbersAsync(string searchId = null, bool? consentToNotResellNumbers = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePurchasePhoneNumbersRequest(searchId, consentToNotResellNumbers);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumbersPurchasePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Purchases phone numbers. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="consentToNotResellNumbers"> The consent to not resell numbers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<PhoneNumbersPurchasePhoneNumbersHeaders> PurchasePhoneNumbers(string searchId = null, bool? consentToNotResellNumbers = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePurchasePhoneNumbersRequest(searchId, consentToNotResellNumbers);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumbersPurchasePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateCapabilitiesRequest(string phoneNumber, PhoneNumberCapabilityType? calling, PhoneNumberCapabilityType? sms)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/phoneNumbers/", false);
            uri.AppendPath(phoneNumber, true);
            uri.AppendPath("/capabilities", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            var model = new PhoneNumberCapabilitiesRequest()
            {
                Calling = calling,
                Sms = sms
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Updates the capabilities of a phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B, e.g. +11234567890. </param>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public async Task<ResponseWithHeaders<PhoneNumbersUpdateCapabilitiesHeaders>> UpdateCapabilitiesAsync(string phoneNumber, PhoneNumberCapabilityType? calling = null, PhoneNumberCapabilityType? sms = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateUpdateCapabilitiesRequest(phoneNumber, calling, sms);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumbersUpdateCapabilitiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates the capabilities of a phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B, e.g. +11234567890. </param>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public ResponseWithHeaders<PhoneNumbersUpdateCapabilitiesHeaders> UpdateCapabilities(string phoneNumber, PhoneNumberCapabilityType? calling = null, PhoneNumberCapabilityType? sms = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateUpdateCapabilitiesRequest(phoneNumber, calling, sms);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumbersUpdateCapabilitiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetByNumberRequest(string phoneNumber)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/phoneNumbers/", false);
            uri.AppendPath(phoneNumber, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the details of the given purchased phone number. </summary>
        /// <param name="phoneNumber"> The purchased phone number whose details are to be fetched in E.164 format, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public async Task<Response<PurchasedPhoneNumber>> GetByNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateGetByNumberRequest(phoneNumber);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PurchasedPhoneNumber value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PurchasedPhoneNumber.DeserializePurchasedPhoneNumber(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the details of the given purchased phone number. </summary>
        /// <param name="phoneNumber"> The purchased phone number whose details are to be fetched in E.164 format, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public Response<PurchasedPhoneNumber> GetByNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateGetByNumberRequest(phoneNumber);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PurchasedPhoneNumber value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PurchasedPhoneNumber.DeserializePurchasedPhoneNumber(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateReleasePhoneNumberRequest(string phoneNumber)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/phoneNumbers/", false);
            uri.AppendPath(phoneNumber, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Releases a purchased phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be released, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public async Task<ResponseWithHeaders<PhoneNumbersReleasePhoneNumberHeaders>> ReleasePhoneNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateReleasePhoneNumberRequest(phoneNumber);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumbersReleasePhoneNumberHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Releases a purchased phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be released, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public ResponseWithHeaders<PhoneNumbersReleasePhoneNumberHeaders> ReleasePhoneNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateReleasePhoneNumberRequest(phoneNumber);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumbersReleasePhoneNumberHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListPhoneNumbersRequest(int? skip, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/phoneNumbers", false);
            if (skip != null)
            {
                uri.AppendQuery("skip", skip.Value, true);
            }
            if (top != null)
            {
                uri.AppendQuery("top", top.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateOperatorInformationSearchRequest(IEnumerable<string> phoneNumbers)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw(_endpoint.AbsoluteUri, false);
            uri.AppendPath("/operatorInformation/:search", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            OperatorInformationRequest operatorInformationRequest = new OperatorInformationRequest();
            if (phoneNumbers != null)
            {
                foreach (var value in phoneNumbers)
                {
                    operatorInformationRequest.PhoneNumbers.Add(value);
                }
            }
            var model = operatorInformationRequest;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Searches for operator information for a given list of phone numbers. </summary>
        /// <param name="phoneNumbers"> Phone number(s) whose operator information is being requested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<OperatorInformationResult>> OperatorInformationSearchAsync(IEnumerable<string> phoneNumbers = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperatorInformationSearchRequest(phoneNumbers);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperatorInformationResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OperatorInformationResult.DeserializeOperatorInformationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Searches for operator information for a given list of phone numbers. </summary>
        /// <param name="phoneNumbers"> Phone number(s) whose operator information is being requested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<OperatorInformationResult> OperatorInformationSearch(IEnumerable<string> phoneNumbers = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperatorInformationSearchRequest(phoneNumbers);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperatorInformationResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OperatorInformationResult.DeserializeOperatorInformationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListAreaCodesNextPageRequest(string nextLink, string twoLetterIsoCountryName, PhoneNumberType phoneNumberType, int? skip, int? maxPageSize, PhoneNumberAssignmentType? assignmentType, string locality, string administrativeDivision, string acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("accept-language", acceptLanguage);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateListAvailableCountriesNextPageRequest(string nextLink, int? skip, int? maxPageSize, string acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("accept-language", acceptLanguage);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateListAvailableLocalitiesNextPageRequest(string nextLink, string twoLetterIsoCountryName, int? skip, int? maxPageSize, string administrativeDivision, string acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("accept-language", acceptLanguage);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateListOfferingsNextPageRequest(string nextLink, string twoLetterIsoCountryName, int? skip, int? maxPageSize, PhoneNumberType? phoneNumberType, PhoneNumberAssignmentType? assignmentType, string acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("accept-language", acceptLanguage);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateListPhoneNumbersNextPageRequest(string nextLink, int? skip, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}

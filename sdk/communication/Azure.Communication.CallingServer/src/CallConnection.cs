// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.CallingServer
{
    /// <summary>
    /// The Azure Communication Services Calling Server client.
    /// </summary>
    public class CallConnection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        internal CallConnectionsRestClient RestClient { get; }

        /// <summary>
        /// The call connection id.
        /// </summary>
        public virtual string CallConnectionId { get; internal set; }

        internal CallConnection(string callConnectionId, CallConnectionsRestClient callConnectionRestClient, ClientDiagnostics clientDiagnostics)
        {
            this.CallConnectionId = callConnectionId;
            this.RestClient = callConnectionRestClient;
            this._clientDiagnostics = clientDiagnostics;
        }

        /// <summary>Initializes a new instance of <see cref="CallingServerClient"/> for mocking.</summary>
        protected CallConnection()
        {
            _clientDiagnostics = null;
            RestClient = null;
            CallConnectionId = null;
        }

        /// <summary> Disconnect the current caller in a group-call or end a p2p-call.</summary>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response> HangupAsync(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(Hangup)}");
            scope.Start();
            try
            {
                return await RestClient.HangupCallAsync(
                    callConnectionId: CallConnectionId,
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Disconnect the current caller in a group-call or end a p2p-call. </summary>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response Hangup(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(Hangup)}");
            scope.Start();
            try
            {
                return RestClient.HangupCall(
                    callConnectionId: CallConnectionId,
                    cancellationToken: cancellationToken
                    );
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Cancel all media operations in the call. </summary>
        /// <param name="operationContext">The operation context. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response<CancelAllMediaOperationsResult>> CancelAllMediaOperationsAsync(string operationContext = null, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(CancelAllMediaOperations)}");
            scope.Start();
            try
            {
                return await RestClient.CancelAllMediaOperationsAsync(
                    callConnectionId: CallConnectionId,
                    operationContext: operationContext,
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Cancel all media operations in the call. </summary>
        /// <param name="operationContext">The operation context. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response<CancelAllMediaOperationsResult> CancelAllMediaOperations(string operationContext = null, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(CancelAllMediaOperations)}");
            scope.Start();
            try
            {
                return RestClient.CancelAllMediaOperations(
                    callConnectionId: CallConnectionId,
                    operationContext: operationContext,
                    cancellationToken: cancellationToken
                    );
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Play audio in the call. </summary>
        /// <param name="audioFileUri">The media resource uri of the play audio request. Currently only Wave file (.wav) format audio prompts are supported. The audio content in the wave file must be mono (single-channel), 16-bit samples with a 16,000 (16KHz) sampling rate.</param>
        /// <param name="options"> Play audio request. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual async Task<Response<PlayAudioResult>> PlayAudioAsync(Uri audioFileUri, PlayAudioOptions options, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(PlayAudio)}");
            scope.Start();
            try
            {
                Argument.AssertNotNull(audioFileUri, nameof(audioFileUri));

                return await RestClient.PlayAudioAsync(
                    callConnectionId: CallConnectionId,
                    audioFileUri: audioFileUri.AbsoluteUri,
                    loop: options?.Loop ?? false,
                    audioFileId: options?.AudioFileId ?? Guid.NewGuid().ToString(),
                    callbackUri: options?.CallbackUri?.AbsoluteUri,
                    operationContext: options?.OperationContext ?? Guid.NewGuid().ToString(),
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Play audio in the call. </summary>
        /// <param name="audioFileUri">The media resource uri of the play audio request. Currently only Wave file (.wav) format audio prompts are supported. The audio content in the wave file must be mono (single-channel), 16-bit samples with a 16,000 (16KHz) sampling rate.</param>
        /// <param name="options"> Play audio request. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual Response<PlayAudioResult> PlayAudio(Uri audioFileUri, PlayAudioOptions options, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(PlayAudio)}");
            scope.Start();
            try
            {
                Argument.AssertNotNull(audioFileUri, nameof(audioFileUri));

                return RestClient.PlayAudio(
                    callConnectionId: CallConnectionId,
                    audioFileUri: audioFileUri.AbsoluteUri,
                    loop: options?.Loop ?? false,
                    audioFileId: options?.AudioFileId ?? Guid.NewGuid().ToString(),
                    callbackUri: options?.CallbackUri?.AbsoluteUri,
                    operationContext: options?.OperationContext ?? Guid.NewGuid().ToString(),
                    cancellationToken: cancellationToken
                    );
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Add a participant to the call. </summary>
        /// <param name="participant"> The identity of participant to be added to the call. </param>
        /// <param name="alternateCallerId">The phone number to use when adding a pstn participant.</param>
        /// <param name="operationContext">The operation context. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"> <paramref name="participant"/> is null. </exception>
        public virtual async Task<Response<AddParticipantResult>> AddParticipantAsync(CommunicationIdentifier participant, string alternateCallerId = default, string operationContext = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(AddParticipant)}");
            scope.Start();
            try
            {
                Argument.AssertNotNull(participant, nameof(participant));

                return await RestClient.AddParticipantAsync(
                    callConnectionId: CallConnectionId,
                    participant: CommunicationIdentifierSerializer.Serialize(participant),
                    alternateCallerId: alternateCallerId == null ? null : new PhoneNumberIdentifierModel(alternateCallerId),
                    operationContext: operationContext,
                    callbackUri: null,
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Add a participant to the call. </summary>
        /// <param name="participant"> The identity of participant to be added to the call. </param>
        /// <param name="alternateCallerId">The phone number to use when adding a pstn participant.</param>
        /// <param name="operationContext">The operation context. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"> <paramref name="participant"/> is null. </exception>
        public virtual Response<AddParticipantResult> AddParticipant(CommunicationIdentifier participant, string alternateCallerId = default, string operationContext = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(AddParticipant)}");
            scope.Start();
            try
            {
                Argument.AssertNotNull(participant, nameof(participant));

                return RestClient.AddParticipant(
                    callConnectionId: CallConnectionId,
                    participant: CommunicationIdentifierSerializer.Serialize(participant),
                    alternateCallerId: alternateCallerId == null ? null : new PhoneNumberIdentifierModel(alternateCallerId),
                    operationContext: operationContext,
                    callbackUri: null,
                    cancellationToken: cancellationToken
                    );
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Remove a participant from the call. </summary>
        /// <param name="participantId"> The participant id. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response> RemoveParticipantAsync(string participantId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(RemoveParticipant)}");
            scope.Start();
            try
            {
                return await RestClient.RemoveParticipantAsync(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Remove a participants from the call. </summary>
        /// <param name="participantId"> The participant id. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response RemoveParticipant(string participantId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(RemoveParticipant)}");
            scope.Start();
            try
            {
                return RestClient.RemoveParticipant(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    cancellationToken: cancellationToken
                    );
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Remove a participant from the call using <see cref="CommunicationIdentifier"/>.</summary>
        /// <param name="participant"> The identity of participant to be removed from the call. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response> RemoveParticipantByIdAsync(CommunicationIdentifier participant, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(RemoveParticipantByIdAsync)}");
            scope.Start();
            try
            {
                return await RestClient.RemoveParticipantByIdAsync(
                    callConnectionId: CallConnectionId,
                    identifier: CommunicationIdentifierSerializer.Serialize(participant),
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Remove a participant from the call using <see cref="CommunicationIdentifier"/>.</summary>
        /// <param name="participant"> The identity of participant to be removed from the call. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response RemoveParticipantById(CommunicationIdentifier participant, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(RemoveParticipantById)}");
            scope.Start();
            try
            {
                return RestClient.RemoveParticipantById(
                    callConnectionId: CallConnectionId,
                    identifier: CommunicationIdentifierSerializer.Serialize(participant),
                    cancellationToken: cancellationToken
                    );
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Transfer the call to a participant. </summary>
        /// <param name="targetParticipant"> The target participant. </param>
        /// <param name="userToUserInformation">The user to user information payload. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response> TransferToParticipantAsync(CommunicationIdentifier targetParticipant, string userToUserInformation, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(TransferToParticipantAsync)}");
            scope.Start();
            try
            {
                return await RestClient.TransferAsync(
                    callConnectionId: CallConnectionId,
                    targetParticipant: CommunicationIdentifierSerializer.Serialize(targetParticipant),
                    userToUserInformation: userToUserInformation,
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Transfer the call to a participant. </summary>
        /// <param name="targetParticipant"> The target participant. </param>
        /// <param name="userToUserInformation">The user to user information payload. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response TransferToParticipant(CommunicationIdentifier targetParticipant, string userToUserInformation, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(TransferToParticipant)}");
            scope.Start();
            try
            {
                return RestClient.Transfer(
                    callConnectionId: CallConnectionId,
                    targetParticipant: CommunicationIdentifierSerializer.Serialize(targetParticipant),
                    userToUserInformation: userToUserInformation,
                    cancellationToken: cancellationToken
                    );
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Get call connection properties. </summary>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <returns>The <see cref="CallConnectionProperties"/>.</returns>
        public virtual async Task<Response<CallConnectionProperties>> GetAsync(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(AddParticipant)}");
            scope.Start();
            try
            {
                Response<CallConnectionPropertiesInternal> callConnectionPropertiesInternal = await RestClient.GetCallAsync(
                                        callConnectionId: CallConnectionId,
                                        cancellationToken: cancellationToken
                                        ).ConfigureAwait(false);

                return Response.FromValue(new CallConnectionProperties(callConnectionPropertiesInternal.Value), callConnectionPropertiesInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Get call connection properties. </summary>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <returns>The <see cref="CallConnectionProperties"/>.</returns>
        public virtual Response<CallConnectionProperties> Get(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(AddParticipant)}");
            scope.Start();
            try
            {
                Response<CallConnectionPropertiesInternal> callConnectionPropertiesInternal = RestClient.GetCall(
                        callConnectionId: CallConnectionId,
                        cancellationToken: cancellationToken
                        );

                return Response.FromValue(new CallConnectionProperties(callConnectionPropertiesInternal.Value), callConnectionPropertiesInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Get participants of the call. </summary>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <returns>The <see cref="IEnumerable{CallParticipant}"/>.</returns>
        public virtual async Task<Response<IEnumerable<CallParticipant>>> GetParticipantsAsync(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(GetParticipantsAsync)}");
            scope.Start();
            try
            {
                Response<IReadOnlyList<CallParticipantInternal>> callParticipantsInternal = await RestClient.GetParticipantsAsync(
                                        callConnectionId: CallConnectionId,
                                        cancellationToken: cancellationToken
                                        ).ConfigureAwait(false);

                return Response.FromValue(callParticipantsInternal.Value.Select(x => new CallParticipant(x)), callParticipantsInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Get participants of the call. </summary>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <returns>The <see cref="IEnumerable{CallParticipant}"/>.</returns>
        public virtual Response<IEnumerable<CallParticipant>> GetParticipants(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(GetParticipants)}");
            scope.Start();
            try
            {
                Response<IReadOnlyList<CallParticipantInternal>> callParticipantsInternal = RestClient.GetParticipants(
                                        callConnectionId: CallConnectionId,
                                        cancellationToken: cancellationToken);

                return Response.FromValue(callParticipantsInternal.Value.Select(x => new CallParticipant(x)), callParticipantsInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Get participant of the call using participant id. </summary>
        /// <param name="participantId">The participant id. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <returns>The <see cref="CallParticipant"/>.</returns>
        public virtual async Task<Response<CallParticipant>> GetParticipantAsync(string participantId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(GetParticipantAsync)}");
            scope.Start();
            try
            {
                Response<CallParticipantInternal> callParticipantInternal = await RestClient.GetParticipantAsync(
                                        callConnectionId: CallConnectionId,
                                        participantId: participantId,
                                        cancellationToken: cancellationToken
                                        ).ConfigureAwait(false);

                return Response.FromValue(new CallParticipant(callParticipantInternal.Value), callParticipantInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Get participant of the call using participant id. </summary>
        /// <param name="participantId">The participant id. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <returns>The <see cref="CallParticipant"/>.</returns>
        public virtual Response<CallParticipant> GetParticipant(string participantId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(GetParticipant)}");
            scope.Start();
            try
            {
                Response<CallParticipantInternal> callParticipantInternal = RestClient.GetParticipant(
                                        callConnectionId: CallConnectionId,
                                        participantId: participantId,
                                        cancellationToken: cancellationToken);

                return Response.FromValue(new CallParticipant(callParticipantInternal.Value), callParticipantInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Get participant from the call using <see cref="CommunicationIdentifier"/>. </summary>
        /// <param name="participant"> The identifier of the participant. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <returns>The <see cref="IEnumerable{CallParticipant}"/>.</returns>
        public virtual async Task<Response<IEnumerable<CallParticipant>>> GetParticipantByIdAsync(CommunicationIdentifier participant, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(GetParticipantByIdAsync)}");
            scope.Start();
            try
            {
                Response<IReadOnlyList<CallParticipantInternal>> callParticipantsInternal = await RestClient.GetParticipantByIdAsync(
                                        callConnectionId: CallConnectionId,
                                        identifier: CommunicationIdentifierSerializer.Serialize(participant),
                                        cancellationToken: cancellationToken
                                        ).ConfigureAwait(false);

                return Response.FromValue(callParticipantsInternal.Value.Select(c => new CallParticipant(c)), callParticipantsInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Get participant from the call using <see cref="CommunicationIdentifier"/>. </summary>
        /// <param name="participant"> The identifier of the participant. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <returns>The <see cref="IEnumerable{CallParticipant}"/>.</returns>
        public virtual Response<IEnumerable<CallParticipant>> GetParticipantById(CommunicationIdentifier participant, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(GetParticipantById)}");
            scope.Start();
            try
            {
                Response<IReadOnlyList<CallParticipantInternal>> callParticipantsInternal = RestClient.GetParticipantById(
                                        callConnectionId: CallConnectionId,
                                        identifier: CommunicationIdentifierSerializer.Serialize(participant),
                                        cancellationToken: cancellationToken);

                return Response.FromValue(callParticipantsInternal.Value.Select(c => new CallParticipant(c)), callParticipantsInternal.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Hold the participant and play default music. </summary>
        /// <param name="participantId">The participant id.</param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response<StartHoldMusicResult>> StartHoldMusicAsync(string participantId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(StartHoldMusicAsync)}");
            scope.Start();
            try
            {
                return await RestClient.StartHoldMusicAsync(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Hold the participant and play default music. </summary>
        /// <param name="participantId">The participant id.</param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response<StartHoldMusicResult> StartHoldMusic(string participantId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(StartHoldMusic)}");
            scope.Start();
            try
            {
                return RestClient.StartHoldMusic(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Hold the participant and play the custom audio. </summary>
        /// <param name="participantId">The participant id.</param>
        /// <param name="audioFileUri"> The uri of the audio file. </param>
        /// <param name="audioFileId">Tne id for the media in the AudioFileUri, using which we cache the media resource. </param>
        /// <param name="callbackUri">The callback Uri to receive StartHoldMusic status notifications. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response<StartHoldMusicResult>> StartHoldMusicAsync(string participantId, Uri audioFileUri, string audioFileId, Uri callbackUri, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(StartHoldMusicAsync)}");
            scope.Start();
            try
            {
                return await RestClient.StartHoldMusicAsync(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    audioFileUri: audioFileUri.AbsoluteUri,
                    audioFileId: audioFileId,
                    callbackUri: callbackUri.AbsoluteUri,
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Hold the participant and play the custom audio. </summary>
        /// <param name="participantId">The participant id.</param>
        /// <param name="audioFileUri"> The uri of the audio file. </param>
        /// <param name="audioFileId">Tne id for the media in the AudioFileUri, using which we cache the media resource. </param>
        /// <param name="callbackUri">The callback Uri to receive StartHoldMusic status notifications. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response<StartHoldMusicResult> StartHoldMusic(string participantId, Uri audioFileUri, string audioFileId, Uri callbackUri, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(StartHoldMusic)}");
            scope.Start();
            try
            {
                return RestClient.StartHoldMusic(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    audioFileUri: audioFileUri.AbsoluteUri,
                    audioFileId: audioFileId,
                    callbackUri: callbackUri.AbsoluteUri,
                    cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Remove participant from the hold and stop playing audio. </summary>
        /// <param name="participantId"> The participant id. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response<StopHoldMusicResult>> StopHoldMusicAsync(string participantId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(StopHoldMusicAsync)}");
            scope.Start();
            try
            {
                return await RestClient.StopHoldMusicAsync(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Remove participant from the hold and stop playing audio. </summary>
        /// <param name="participantId"> The participant id. </param>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response<StopHoldMusicResult> StopHoldMusic(string participantId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(StopHoldMusic)}");
            scope.Start();
            try
            {
                return RestClient.StopHoldMusic(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    cancellationToken: cancellationToken
                    );
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Keep call connection alive. </summary>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response> KeepAliveAsync(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(KeepAliveAsync)}");
            scope.Start();
            try
            {
                return await RestClient.KeepAliveAsync(
                    callConnectionId: CallConnectionId,
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Keep call connection alive. </summary>
        /// <param name="cancellationToken"> The cancellation token. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response KeepAlive(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(KeepAlive)}");
            scope.Start();
            try
            {
                return RestClient.KeepAlive(
                    callConnectionId: CallConnectionId,
                    cancellationToken: cancellationToken
                    );
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Play audio to a participant. </summary>
        /// <param name="participantId">The participant id.</param>
        /// <param name="audioFileUri">The media resource uri of the play audio request. Currently only Wave file (.wav) format audio prompts are supported. The audio content in the wave file must be mono (single-channel), 16-bit samples with a 16,000 (16KHz) sampling rate.</param>
        /// <param name="options"> Options for playing audio. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response<PlayAudioResult>> PlayAudioToParticipantAsync(string participantId, Uri audioFileUri, PlayAudioOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(audioFileUri, nameof(audioFileUri));
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(PlayAudioToParticipantAsync)}");
            scope.Start();
            try
            {
                return await RestClient.ParticipantPlayAudioAsync(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    audioFileUri: audioFileUri.AbsoluteUri,
                    loop: options?.Loop ?? false,
                    audioFileId: options?.AudioFileId ?? Guid.NewGuid().ToString(),
                    callbackUri: options?.CallbackUri?.AbsoluteUri,
                    operationContext: options?.OperationContext ?? Guid.NewGuid().ToString(),
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Play audio to a participant. </summary>
        /// <param name="participantId">The participant id.</param>
        /// <param name="audioFileUri">The media resource uri of the play audio request. Currently only Wave file (.wav) format audio prompts are supported. The audio content in the wave file must be mono (single-channel), 16-bit samples with a 16,000 (16KHz) sampling rate.</param>
        /// <param name="options"> Options for playing audio. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response<PlayAudioResult> PlayAudioToParticipant(string participantId, Uri audioFileUri, PlayAudioOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(audioFileUri, nameof(audioFileUri));
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(PlayAudioToParticipant)}");
            scope.Start();
            try
            {
                return RestClient.ParticipantPlayAudio(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    audioFileUri: audioFileUri.AbsoluteUri,
                    loop: options?.Loop ?? false,
                    audioFileId: options?.AudioFileId ?? Guid.NewGuid().ToString(),
                    callbackUri: options?.CallbackUri?.AbsoluteUri,
                    operationContext: options?.OperationContext ?? Guid.NewGuid().ToString(),
                    cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Cancel Participant Media Operation. </summary>
        /// <param name="participantId">The participant id.</param>
        /// <param name="mediaOperationId">The Id of the media operation to Cancel. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response> CancelParticipantMediaOperationAsync(string participantId, string mediaOperationId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(CancelParticipantMediaOperationAsync)}");
            scope.Start();
            try
            {
                return await RestClient.CancelParticipantMediaOperationAsync(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    mediaOperationId: mediaOperationId,
                    cancellationToken: cancellationToken
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Cancel Participant Media Operation. </summary>
        /// <param name="participantId">The participant id.</param>
        /// <param name="mediaOperationId">The Id of the media operation to Cancel. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response CancelParticipantMediaOperation(string participantId, string mediaOperationId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(CallConnection)}.{nameof(CancelParticipantMediaOperation)}");
            scope.Start();
            try
            {
                return RestClient.CancelParticipantMediaOperation(
                    callConnectionId: CallConnectionId,
                    participantId: participantId,
                    mediaOperationId: mediaOperationId,
                    cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SelfHelp;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmSelfHelpModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.SelfHelpNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Returns true or false depending on the availability of the name. </param>
        /// <param name="reason"> Reason for why value is not available. This field is returned if nameAvailable is false. </param>
        /// <param name="message"> Gets an error message explaining the 'reason' value with more details. This field is returned iif nameAvailable is false. </param>
        /// <returns> A new <see cref="Models.SelfHelpNameAvailabilityResult"/> instance for mocking. </returns>
        public static SelfHelpNameAvailabilityResult SelfHelpNameAvailabilityResult(bool? isNameAvailable = null, string reason = null, string message = null)
        {
            return new SelfHelpNameAvailabilityResult(isNameAvailable, reason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="SelfHelp.SelfHelpDiagnosticData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="globalParameters"> Global parameters that can be passed to all solutionIds. </param>
        /// <param name="insights"> SolutionIds that are needed to be invoked. </param>
        /// <param name="acceptedOn"> Diagnostic Request Accepted time. </param>
        /// <param name="provisioningState"> Status of diagnostic provisioning. </param>
        /// <param name="diagnostics"> Array of Diagnostics. </param>
        /// <returns> A new <see cref="SelfHelp.SelfHelpDiagnosticData"/> instance for mocking. </returns>
        public static SelfHelpDiagnosticData SelfHelpDiagnosticData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> globalParameters = null, IEnumerable<SelfHelpDiagnosticInvocation> insights = null, DateTimeOffset? acceptedOn = null, SelfHelpProvisioningState? provisioningState = null, IEnumerable<SelfHelpDiagnosticInfo> diagnostics = null)
        {
            globalParameters ??= new Dictionary<string, string>();
            insights ??= new List<SelfHelpDiagnosticInvocation>();
            diagnostics ??= new List<SelfHelpDiagnosticInfo>();

            return new SelfHelpDiagnosticData(id, name, resourceType, systemData, globalParameters, insights?.ToList(), acceptedOn, provisioningState, diagnostics?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SelfHelpDiagnosticInfo"/>. </summary>
        /// <param name="solutionId"> Solution Id. </param>
        /// <param name="status"> Denotes the status of the diagnostic resource. </param>
        /// <param name="insights"> The problems (if any) detected by this insight. </param>
        /// <param name="error"> Error definition. </param>
        /// <returns> A new <see cref="Models.SelfHelpDiagnosticInfo"/> instance for mocking. </returns>
        public static SelfHelpDiagnosticInfo SelfHelpDiagnosticInfo(string solutionId = null, SelfHelpDiagnosticStatus? status = null, IEnumerable<SelfHelpDiagnosticInsight> insights = null, SelfHelpError error = null)
        {
            insights ??= new List<SelfHelpDiagnosticInsight>();

            return new SelfHelpDiagnosticInfo(solutionId, status, insights?.ToList(), error, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SelfHelpError"/>. </summary>
        /// <param name="code"> Service specific error code which serves as the substatus for the HTTP error code. </param>
        /// <param name="errorType"> Service specific error type which serves as additional context for the error herein. </param>
        /// <param name="message"> Description of the error. </param>
        /// <param name="details"> An array of additional nested error response info objects, as described by this contract. </param>
        /// <returns> A new <see cref="Models.SelfHelpError"/> instance for mocking. </returns>
        public static SelfHelpError SelfHelpError(string code = null, string errorType = null, string message = null, IEnumerable<SelfHelpError> details = null)
        {
            details ??= new List<SelfHelpError>();

            return new SelfHelpError(code, errorType, message, details?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SelfHelpSolutionMetadata"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="solutions"> List of metadata. </param>
        /// <returns> A new <see cref="Models.SelfHelpSolutionMetadata"/> instance for mocking. </returns>
        public static SelfHelpSolutionMetadata SelfHelpSolutionMetadata(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<SolutionMetadataProperties> solutions = null)
        {
            solutions ??= new List<SolutionMetadataProperties>();

            return new SelfHelpSolutionMetadata(id, name, resourceType, systemData, solutions?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SolutionMetadataProperties"/>. </summary>
        /// <param name="solutionId"> Solution Id. </param>
        /// <param name="solutionType"> Solution Type. </param>
        /// <param name="description"> A detailed description of solution. </param>
        /// <param name="requiredInputs"> Required parameters for invoking this particular solution. </param>
        /// <returns> A new <see cref="Models.SolutionMetadataProperties"/> instance for mocking. </returns>
        public static SolutionMetadataProperties SolutionMetadataProperties(string solutionId = null, SolutionType? solutionType = null, string description = null, IEnumerable<string> requiredInputs = null)
        {
            requiredInputs ??= new List<string>();

            return new SolutionMetadataProperties(solutionId, solutionType, description, requiredInputs?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="SelfHelp.SolutionResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Solution result. </param>
        /// <returns> A new <see cref="SelfHelp.SolutionResourceData"/> instance for mocking. </returns>
        public static SolutionResourceData SolutionResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, SolutionResourceProperties properties = null)
        {
            return new SolutionResourceData(id, name, resourceType, systemData, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="SelfHelp.TroubleshooterResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="solutionId"> Solution Id to identify single troubleshooter. </param>
        /// <param name="parameters"> Client input parameters to run Troubleshooter Resource. </param>
        /// <param name="provisioningState"> Status of troubleshooter provisioning. </param>
        /// <param name="steps"> List of step object. </param>
        /// <returns> A new <see cref="SelfHelp.TroubleshooterResourceData"/> instance for mocking. </returns>
        public static TroubleshooterResourceData TroubleshooterResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string solutionId = null, IDictionary<string, string> parameters = null, TroubleshooterProvisioningState? provisioningState = null, IEnumerable<SelfHelpStep> steps = null)
        {
            parameters ??= new Dictionary<string, string>();
            steps ??= new List<SelfHelpStep>();

            return new TroubleshooterResourceData(id, name, resourceType, systemData, solutionId, parameters, provisioningState, steps?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SelfHelpStep"/>. </summary>
        /// <param name="id"> Unique step id. </param>
        /// <param name="title"> Step title. </param>
        /// <param name="description"> Step description. </param>
        /// <param name="guidance"> Get or sets the Step guidance. </param>
        /// <param name="executionStatus"> Status of Troubleshooter Step execution. </param>
        /// <param name="executionStatusDescription"> This field has more detailed status description of the execution status. </param>
        /// <param name="stepType"> Type of Troubleshooting step. </param>
        /// <param name="isLastStep"> is this last step of the workflow. </param>
        /// <param name="inputs"></param>
        /// <param name="automatedCheckResults"> Only for AutomatedStep type. </param>
        /// <param name="insights"></param>
        /// <param name="error"> The error detail. </param>
        /// <returns> A new <see cref="Models.SelfHelpStep"/> instance for mocking. </returns>
        public static SelfHelpStep SelfHelpStep(string id = null, string title = null, string description = null, string guidance = null, ExecutionStatus? executionStatus = null, string executionStatusDescription = null, SelfHelpType? stepType = null, bool? isLastStep = null, IEnumerable<StepInput> inputs = null, AutomatedCheckResult automatedCheckResults = null, IEnumerable<SelfHelpDiagnosticInsight> insights = null, ResponseError error = null)
        {
            inputs ??= new List<StepInput>();
            insights ??= new List<SelfHelpDiagnosticInsight>();

            return new SelfHelpStep(id, title, description, guidance, executionStatus, executionStatusDescription, stepType, isLastStep, inputs?.ToList(), automatedCheckResults, insights?.ToList(), error, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StepInput"/>. </summary>
        /// <param name="questionId"> Use Index as QuestionId. </param>
        /// <param name="questionType"> Text Input. Will be a single line input. </param>
        /// <param name="questionContent"> User question content. </param>
        /// <param name="questionContentType"> Default is Text. </param>
        /// <param name="responseHint"> Place holder text for response hints. </param>
        /// <param name="recommendedOption"> Result of Automate step. </param>
        /// <param name="selectedOptionValue"> Text of response that was selected. </param>
        /// <param name="responseValidationProperties"> Troubleshooter step input response validation properties. </param>
        /// <param name="responseOptions"></param>
        /// <returns> A new <see cref="Models.StepInput"/> instance for mocking. </returns>
        public static StepInput StepInput(string questionId = null, string questionType = null, string questionContent = null, QuestionContentType? questionContentType = null, string responseHint = null, string recommendedOption = null, string selectedOptionValue = null, ResponseValidationProperties responseValidationProperties = null, IEnumerable<ResponseConfig> responseOptions = null)
        {
            responseOptions ??= new List<ResponseConfig>();

            return new StepInput(questionId, questionType, questionContent, questionContentType, responseHint, recommendedOption, selectedOptionValue, responseValidationProperties, responseOptions?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ResponseValidationProperties"/>. </summary>
        /// <param name="regex"> Regex used for the input validation. </param>
        /// <param name="isRequired"> Default True. </param>
        /// <param name="validationErrorMessage"> Validation Error Message. </param>
        /// <param name="maxLength"> Max text input (open Ended Text). </param>
        /// <returns> A new <see cref="Models.ResponseValidationProperties"/> instance for mocking. </returns>
        public static ResponseValidationProperties ResponseValidationProperties(string regex = null, bool? isRequired = null, string validationErrorMessage = null, long? maxLength = null)
        {
            return new ResponseValidationProperties(regex, isRequired, validationErrorMessage, maxLength, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ResponseConfig"/>. </summary>
        /// <param name="key"> Unique string. </param>
        /// <param name="value"> Option description. </param>
        /// <returns> A new <see cref="Models.ResponseConfig"/> instance for mocking. </returns>
        public static ResponseConfig ResponseConfig(string key = null, string value = null)
        {
            return new ResponseConfig(key, value, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AutomatedCheckResult"/>. </summary>
        /// <param name="result"> Insight Article Content. </param>
        /// <param name="resultType"> Type of Result. </param>
        /// <returns> A new <see cref="Models.AutomatedCheckResult"/> instance for mocking. </returns>
        public static AutomatedCheckResult AutomatedCheckResult(string result = null, AutomatedCheckResultType? resultType = null)
        {
            return new AutomatedCheckResult(result, resultType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.RestartTroubleshooterResult"/>. </summary>
        /// <param name="troubleshooterResourceName"> Updated TroubleshooterResource Name . </param>
        /// <returns> A new <see cref="Models.RestartTroubleshooterResult"/> instance for mocking. </returns>
        public static RestartTroubleshooterResult RestartTroubleshooterResult(string troubleshooterResourceName = null)
        {
            return new RestartTroubleshooterResult(troubleshooterResourceName, serializedAdditionalRawData: null);
        }
    }
}

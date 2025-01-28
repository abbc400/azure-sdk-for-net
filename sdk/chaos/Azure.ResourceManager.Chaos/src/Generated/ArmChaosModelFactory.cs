// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmChaosModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.OperationStatusResult"/>. </summary>
        /// <param name="id"> Fully qualified ID for the async operation. </param>
        /// <param name="name"> Name of the async operation. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="endOn"> The end time of the operation. </param>
        /// <param name="operations"> The operations list. </param>
        /// <param name="error"> If present, details of the operation error. </param>
        /// <param name="resourceId"> Fully qualified ID of the resource against which the original async operation was started. </param>
        /// <returns> A new <see cref="Models.OperationStatusResult"/> instance for mocking. </returns>
        public static OperationStatusResult OperationStatusResult(ResourceIdentifier id = null, string name = null, string status = null, double? percentComplete = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, IEnumerable<OperationStatusResult> operations = null, ResponseError error = null, string resourceId = null)
        {
            operations ??= new List<OperationStatusResult>();

            return new OperationStatusResult(
                id,
                name,
                status,
                percentComplete,
                startOn,
                endOn,
                operations?.ToList(),
                error,
                resourceId,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Chaos.ChaosTargetMetadataData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Localized string of the display name. </param>
        /// <param name="description"> Localized string of the description. </param>
        /// <param name="propertiesSchema"> URL to retrieve JSON schema of the Target Type properties. </param>
        /// <param name="resourceTypes"> List of resource types this Target Type can extend. </param>
        /// <returns> A new <see cref="Chaos.ChaosTargetMetadataData"/> instance for mocking. </returns>
        public static ChaosTargetMetadataData ChaosTargetMetadataData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, string description = null, string propertiesSchema = null, IEnumerable<string> resourceTypes = null)
        {
            resourceTypes ??= new List<string>();

            return new ChaosTargetMetadataData(
                id,
                name,
                resourceType,
                systemData,
                displayName,
                description,
                propertiesSchema,
                resourceTypes?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Chaos.ChaosExperimentExecutionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> The status of the execution. </param>
        /// <param name="startedOn"> String that represents the start date time. </param>
        /// <param name="stoppedOn"> String that represents the stop date time. </param>
        /// <returns> A new <see cref="Chaos.ChaosExperimentExecutionData"/> instance for mocking. </returns>
        public static ChaosExperimentExecutionData ChaosExperimentExecutionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string status = null, DateTimeOffset? startedOn = null, DateTimeOffset? stoppedOn = null)
        {
            return new ChaosExperimentExecutionData(
                id,
                name,
                resourceType,
                systemData,
                status,
                startedOn,
                stoppedOn,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ExperimentExecutionDetails"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> The status of the execution. </param>
        /// <param name="startedOn"> String that represents the start date time. </param>
        /// <param name="stoppedOn"> String that represents the stop date time. </param>
        /// <param name="failureReason"> The reason why the execution failed. </param>
        /// <param name="lastActionOn"> String that represents the last action date time. </param>
        /// <param name="runInformationSteps"> The information of the experiment run. </param>
        /// <returns> A new <see cref="Models.ExperimentExecutionDetails"/> instance for mocking. </returns>
        public static ExperimentExecutionDetails ExperimentExecutionDetails(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string status = null, DateTimeOffset? startedOn = null, DateTimeOffset? stoppedOn = null, string failureReason = null, DateTimeOffset? lastActionOn = null, IEnumerable<ChaosExperimentRunStepStatus> runInformationSteps = null)
        {
            runInformationSteps ??= new List<ChaosExperimentRunStepStatus>();

            return new ExperimentExecutionDetails(
                id,
                name,
                resourceType,
                systemData,
                status,
                startedOn,
                stoppedOn,
                failureReason,
                lastActionOn,
                runInformationSteps != null ? new ExperimentExecutionDetailsPropertiesRunInformation(runInformationSteps?.ToList(), serializedAdditionalRawData: null) : null,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ChaosExperimentRunStepStatus"/>. </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="stepId"> The id of the step. </param>
        /// <param name="status"> The value of the status of the step. </param>
        /// <param name="branches"> The array of branches. </param>
        /// <returns> A new <see cref="Models.ChaosExperimentRunStepStatus"/> instance for mocking. </returns>
        public static ChaosExperimentRunStepStatus ChaosExperimentRunStepStatus(string stepName = null, string stepId = null, string status = null, IEnumerable<ChaosExperimentRunBranchStatus> branches = null)
        {
            branches ??= new List<ChaosExperimentRunBranchStatus>();

            return new ChaosExperimentRunStepStatus(stepName, stepId, status, branches?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ChaosExperimentRunBranchStatus"/>. </summary>
        /// <param name="branchName"> The name of the branch status. </param>
        /// <param name="branchId"> The id of the branch status. </param>
        /// <param name="status"> The status of the branch. </param>
        /// <param name="actions"> The array of actions. </param>
        /// <returns> A new <see cref="Models.ChaosExperimentRunBranchStatus"/> instance for mocking. </returns>
        public static ChaosExperimentRunBranchStatus ChaosExperimentRunBranchStatus(string branchName = null, string branchId = null, string status = null, IEnumerable<ChaosExperimentRunActionStatus> actions = null)
        {
            actions ??= new List<ChaosExperimentRunActionStatus>();

            return new ChaosExperimentRunBranchStatus(branchName, branchId, status, actions?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ChaosExperimentRunActionStatus"/>. </summary>
        /// <param name="actionName"> The name of the action status. </param>
        /// <param name="actionId"> The id of the action status. </param>
        /// <param name="status"> The status of the action. </param>
        /// <param name="startOn"> String that represents the start time of the action. </param>
        /// <param name="endOn"> String that represents the end time of the action. </param>
        /// <param name="targets"> The array of targets. </param>
        /// <returns> A new <see cref="Models.ChaosExperimentRunActionStatus"/> instance for mocking. </returns>
        public static ChaosExperimentRunActionStatus ChaosExperimentRunActionStatus(string actionName = null, string actionId = null, string status = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, IEnumerable<ExperimentExecutionActionTargetDetailsProperties> targets = null)
        {
            targets ??= new List<ExperimentExecutionActionTargetDetailsProperties>();

            return new ChaosExperimentRunActionStatus(
                actionName,
                actionId,
                status,
                startOn,
                endOn,
                targets?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ExperimentExecutionActionTargetDetailsProperties"/>. </summary>
        /// <param name="status"> The status of the execution. </param>
        /// <param name="target"> The target for the action. </param>
        /// <param name="targetFailedOn"> String that represents the failed date time. </param>
        /// <param name="targetCompletedOn"> String that represents the completed date time. </param>
        /// <param name="error"> The error of the action. </param>
        /// <returns> A new <see cref="Models.ExperimentExecutionActionTargetDetailsProperties"/> instance for mocking. </returns>
        public static ExperimentExecutionActionTargetDetailsProperties ExperimentExecutionActionTargetDetailsProperties(string status = null, string target = null, DateTimeOffset? targetFailedOn = null, DateTimeOffset? targetCompletedOn = null, ExperimentExecutionActionTargetDetailsError error = null)
        {
            return new ExperimentExecutionActionTargetDetailsProperties(
                status,
                target,
                targetFailedOn,
                targetCompletedOn,
                error,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ExperimentExecutionActionTargetDetailsError"/>. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <returns> A new <see cref="Models.ExperimentExecutionActionTargetDetailsError"/> instance for mocking. </returns>
        public static ExperimentExecutionActionTargetDetailsError ExperimentExecutionActionTargetDetailsError(string code = null, string message = null)
        {
            return new ExperimentExecutionActionTargetDetailsError(code, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Chaos.ChaosExperimentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="provisioningState"> Most recent provisioning state for the given experiment resource. </param>
        /// <param name="steps"> List of steps. </param>
        /// <param name="selectors">
        /// List of selectors.
        /// Please note <see cref="ChaosTargetSelector"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ChaosTargetListSelector"/> and <see cref="ChaosTargetQuerySelector"/>.
        /// </param>
        /// <returns> A new <see cref="Chaos.ChaosExperimentData"/> instance for mocking. </returns>
        public static ChaosExperimentData ChaosExperimentData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, ChaosProvisioningState? provisioningState = null, IEnumerable<ChaosExperimentStep> steps = null, IEnumerable<ChaosTargetSelector> selectors = null)
        {
            tags ??= new Dictionary<string, string>();
            steps ??= new List<ChaosExperimentStep>();
            selectors ??= new List<ChaosTargetSelector>();

            return new ChaosExperimentData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                identity,
                provisioningState,
                steps?.ToList(),
                selectors?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Chaos.ChaosCapabilityMetadataData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="publisher"> String of the Publisher that this Capability Type extends. </param>
        /// <param name="targetType"> String of the Target Type that this Capability Type extends. </param>
        /// <param name="displayName"> Localized string of the display name. </param>
        /// <param name="description"> Localized string of the description. </param>
        /// <param name="parametersSchema"> URL to retrieve JSON schema of the Capability Type parameters. </param>
        /// <param name="urn"> String of the URN for this Capability Type. </param>
        /// <param name="kind"> String of the kind of this Capability Type. </param>
        /// <param name="azureRbacActions"> Control plane actions necessary to execute capability type. </param>
        /// <param name="azureRbacDataActions"> Data plane actions necessary to execute capability type. </param>
        /// <param name="requiredAzureRoleDefinitionIds"> Required Azure Role Definition Ids to execute capability type. </param>
        /// <param name="runtimeKind"> Runtime properties of this Capability Type. </param>
        /// <returns> A new <see cref="Chaos.ChaosCapabilityMetadataData"/> instance for mocking. </returns>
        public static ChaosCapabilityMetadataData ChaosCapabilityMetadataData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string publisher = null, string targetType = null, string displayName = null, string description = null, string parametersSchema = null, string urn = null, string kind = null, IEnumerable<string> azureRbacActions = null, IEnumerable<string> azureRbacDataActions = null, IEnumerable<string> requiredAzureRoleDefinitionIds = null, string runtimeKind = null)
        {
            azureRbacActions ??= new List<string>();
            azureRbacDataActions ??= new List<string>();
            requiredAzureRoleDefinitionIds ??= new List<string>();

            return new ChaosCapabilityMetadataData(
                id,
                name,
                resourceType,
                systemData,
                publisher,
                targetType,
                displayName,
                description,
                parametersSchema,
                urn,
                kind,
                azureRbacActions?.ToList(),
                azureRbacDataActions?.ToList(),
                requiredAzureRoleDefinitionIds?.ToList(),
                runtimeKind != null ? new ChaosCapabilityMetadataRuntimeProperties(runtimeKind, serializedAdditionalRawData: null) : null,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Chaos.ChaosTargetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of the target resource. </param>
        /// <param name="location"> Azure resource location. </param>
        /// <returns> A new <see cref="Chaos.ChaosTargetData"/> instance for mocking. </returns>
        public static ChaosTargetData ChaosTargetData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, BinaryData> properties = null, AzureLocation? location = null)
        {
            properties ??= new Dictionary<string, BinaryData>();

            return new ChaosTargetData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                location,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Chaos.ChaosCapabilityData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="publisher"> String of the Publisher that this Capability extends. </param>
        /// <param name="targetType"> String of the Target Type that this Capability extends. </param>
        /// <param name="description"> Localized string of the description. </param>
        /// <param name="parametersSchema"> URL to retrieve JSON schema of the Capability parameters. </param>
        /// <param name="urn"> String of the URN for this Capability Type. </param>
        /// <returns> A new <see cref="Chaos.ChaosCapabilityData"/> instance for mocking. </returns>
        public static ChaosCapabilityData ChaosCapabilityData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string publisher = null, string targetType = null, string description = null, string parametersSchema = null, string urn = null)
        {
            return new ChaosCapabilityData(
                id,
                name,
                resourceType,
                systemData,
                publisher,
                targetType,
                description,
                parametersSchema,
                urn,
                serializedAdditionalRawData: null);
        }
    }
}

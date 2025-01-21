﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;

namespace Azure.AI.Projects.Tests;

public partial class Sample_Agent_Vector_Store_Batch_File_Search : SamplesBase<AIProjectsTestEnvironment>
{
    private static string GetFile([CallerFilePath] string pth = "")
    {
        var dirName = Path.GetDirectoryName(pth) ?? "";
        return Path.Combine(dirName, "product_info_1.md");
    }

    [Test]
    public async Task VectorStoreBatchFileSearch()
    {
        var connectionString = TestEnvironment.AzureAICONNECTIONSTRING;
        var filePath = GetFile();
        var modelName = TestEnvironment.MODELDEPLOYMENTNAME;
        AgentsClient client = new AgentsClient(connectionString, new DefaultAzureCredential());

        var vectorStoreTask = await client.CreateVectorStoreAsync(
            name: "sample_vector_store"
        );
        var vectorStore = vectorStoreTask.Value;

        var fileResponse = await client.UploadFileAsync(filePath, AgentFilePurpose.Agents);
        var fileId = fileResponse.Value.Id;

        var uploadTask = await client.CreateVectorStoreFileBatchAsync(
            vectorStoreId: vectorStore.Id,
            fileIds: [fileId]
        );
        Console.WriteLine($"Created vector store file batch, vector store file batch ID: {uploadTask.Value.Id}");

        FileSearchToolResource fileSearchResource = new([vectorStore.Id], null);

        List<ToolDefinition> tools = [new FileSearchToolDefinition()];
        Response<Agent> agentResponse = await client.CreateAgentAsync(
            model: modelName,
            name: "my-assistant",
            instructions: "You are helpful assistant.",
            tools: tools,
            toolResources: new ToolResources() { FileSearch = fileSearchResource }
        );

        Response<AgentThread> threadResponse = await client.CreateThreadAsync();
        AgentThread thread = threadResponse.Value;

        Response<ThreadMessage> messageResponse = await client.CreateMessageAsync(
            threadId: thread.Id,
            role: MessageRole.User,
            content: "What feature does Smart Eyewear offer?"
            );
        ThreadMessage message = messageResponse.Value;

        Response<ThreadRun> runResponse = await client.CreateRunAsync(
            thread.Id,
            agentResponse.Value.Id
        );
        ThreadRun run = runResponse.Value;

        do
        {
            await Task.Delay(TimeSpan.FromMilliseconds(500));
            runResponse = await client.GetRunAsync(thread.Id, runResponse.Value.Id);
        }
        while (runResponse.Value.Status == RunStatus.Queued
            || runResponse.Value.Status == RunStatus.InProgress);

        Response<PageableList<ThreadMessage>> afterRunMessagesResponse
            = await client.GetMessagesAsync(thread.Id);
        IReadOnlyList<ThreadMessage> messages = afterRunMessagesResponse.Value.Data;
        WriteMessages(messages);

        var delTask = await client.DeleteVectorStoreAsync(vectorStore.Id);
        if (delTask.Value.Deleted)
        {
            Console.WriteLine($"Deleted vector store {vectorStore.Id}");
        }
        else
        {
            Console.WriteLine($"Unable to delete vector store {vectorStore.Id}");
        }
        await client.DeleteAgentAsync(agentResponse.Value.Id);
    }

    private void WriteMessages(IEnumerable<ThreadMessage> messages)
    {
        foreach (ThreadMessage threadMessage in messages)
        {
            Console.Write($"{threadMessage.CreatedAt:yyyy-MM-dd HH:mm:ss} - {threadMessage.Role,10}: ");
            foreach (MessageContent contentItem in threadMessage.ContentItems)
            {
                if (contentItem is MessageTextContent textItem)
                {
                    Console.Write(textItem.Text);
                }
                else if (contentItem is MessageImageFileContent imageFileItem)
                {
                    Console.Write($"<image from ID: {imageFileItem.FileId}");
                }
                Console.WriteLine();
            }
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.AI;

namespace LLMs.Handler;

public static class LLMsHandler
{
    public static WebApplicationBuilder AddLLMsHandler(this WebApplicationBuilder builder)
    {
        var configuration = builder.Configuration;
        string ollamaBaseUrl =  "http://localhost:11434";
        string modelName = "deepseek-r1:8b";

        // Register OllamaChatClient
        builder.Services.AddSingleton<IChatClient>(sp => new OllamaChatClient(new Uri(ollamaBaseUrl), modelName));

        return builder;
    }
}

using LLMs.Handler;
using Microsoft.Extensions.AI;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.AddLLMsHandler();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// LLM chat endpoint
app.MapPost("/chat", async ([FromServices] IChatClient chatClient, [FromBody] ChatRequest request) =>
{
    var response = await chatClient.GetResponseAsync(request.Message);
    return Results.Ok(new { Response = response });
})
.WithName("ChatWithLLM")
.WithOpenApi();

app.Run();


record ChatRequest(string Message);

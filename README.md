# DotNet.LLMs.API

## Overview
DotNet.LLMs.API is a lightweight ASP.NET Core Web API that integrates with **Ollama** to provide Large Language Model (LLM) interactions. This API allows users to send messages to the LLM and receive intelligent responses locally.

## Features
- 🚀 **Chat with an LLM**: Send a message via a simple API endpoint and get a response.
- 🔧 **Swagger Integration**: Easily explore and test API endpoints.
- 🛠 **.NET 8 & Dependency Injection**: Built with .NET 8.
- 🤖 **Uses `deepseek-r1:8b` Model**: This example utilizes the `deepseek-r1:8b` model for LLM interactions.

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Ollama](https://ollama.com/) running locally at `http://localhost:11434`

### Installation
1. Clone this repository:
   ```sh
   git clone https://github.com/iliass-git/chat-with-local-llms.git
   cd DotNet.LLMs.API
   ```
2. Install dependencies:
   ```sh
   dotnet restore
   ```
3. Run the application:
   ```sh
   dotnet run
   ```

## API Usage

### **Chat with LLM**
**Endpoint:** `POST /chat`

**Request:**
```json
{
  "message": "How to implement Factorial Calculation using C#?"
}
```

**Response:**
```json
{
  "response": {
    "choices": [
      {
        "authorName": null,
        "role": "assistant",
        "contents": [
          {
            "$type": "text",
            "text": "<think>\nOkay, so I need to figure out how to calculate the factorial of a number using C#. Hmm, factorials are those products where you multiply all the positive integers up to that number. Like, 5! is 5×4×3×2×1, which equals 120. Right.\n\nFirst, I should remember what a function is in C#. Oh yeah, it's like a method that can perform operations and return results. So maybe I'll need a method called CalculateFactorial that takes an integer and returns its factorial...",
            "additionalProperties": null
          }
        ],
        "additionalProperties": null
      }
    ],
    "responseId": "2025-03-02T10:32:49.311365185Z",
    "chatThreadId": null,
    "modelId": "deepseek-r1:8b",
    "createdAt": "2025-03-02T10:32:49.3113652+00:00",
    "finishReason": "stop",
    "usage": {
      "inputTokenCount": 13,
      "outputTokenCount": 1207,
      "totalTokenCount": 1220,
      "additionalCounts": {
        "load_duration": 23984957251,
        "total_duration": 407548402974,
        "prompt_eval_duration": 1078000000,
        "eval_duration": 382482000000
      }
    },
    "additionalProperties": null
  }
}

```

## Upcoming Features 🚀
- **File Upload & Analysis**: Users will be able to upload documents, and the LLM will analyze their content to generate insights.

## License
This project is licensed under the MIT License.


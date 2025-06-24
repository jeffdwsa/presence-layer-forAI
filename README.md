# Presence Layer for AI 🤖🧠

A contextual awareness layer for AI — combining time, location, weather, recent history, and user input to generate more grounded, human-like prompts.

---

## 🚀 Features

This REST API dynamically builds a **contextual prompt** including:

- 🕒 Current date and time
- 📍 User location (simulated)
- 🌤️ Current weather (simulated)
- 🧠 Recent conversation history
- 📰 Latest news (simulated)
- 💬 User message

The final prompt can then be passed to any LLM, like GPT-4 or GPT-4o via OpenAI API.

---

## 🛠️ Tech Stack

- ASP.NET Core 9 Web API
- Dependency Injection (DI)
- `HttpClient` integration with OpenAI
- Clean architecture with `Services`, `Controllers`, `Models`, and `Middleware`

---

## ▶️ Getting Started

### 1. **Requirements**
- [.NET 9 SDK](https://dotnet.microsoft.com/)
- [OpenAI API Key](https://platform.openai.com/account/api-keys)

### 2. **Configure `appsettings.json`**

```json
{
  "OpenAI": {
    "ApiKey": "your-openai-api-key-here"
  }
}

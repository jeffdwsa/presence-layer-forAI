# Presence Layer for AI 🤖🧠

A contextual awareness layer for AI — combining time, location, weather, recent history, and user input to generate more grounded, human-like prompts.

---

## 🚀 Features

This REST API dynamically builds a **contextual prompt** including:

* 🕒 Current date and time
* 📍 User location (simulated)
* 🌤️ Current weather (simulated)
* 🧠 Recent conversation history
* 📰 Latest news (simulated)
* 💬 User message

The final prompt can then be passed to any LLM, like GPT-4 or GPT-4o via OpenAI API.

---

## 💠 Tech Stack

* ASP.NET Core 9 Web API
* Dependency Injection (DI)
* `HttpClient` integration with OpenAI
* Clean architecture with `Services`, `Controllers`, `Models`, and `Middleware`

---

## ▶️ Getting Started

### 1. **Requirements**

* [.NET 9 SDK](https://dotnet.microsoft.com/)
* [OpenAI API Key](https://platform.openai.com/account/api-keys)

### 2. **Configure `appsettings.json`**

```json
{
  "OpenAI": {
    "ApiKey": "your-openai-api-key-here"
  }
}
```

### 3. **Run the project**

```bash
dotnet run
```

By default, it will be accessible at:
`http://localhost:5000`

---

## 🧺 Postman Testing

### 🔹 Endpoint: Generate contextual prompt

* **POST** `/api/prompt`
* **Body (raw JSON):**

```json
{
  "userMessage": "What's the weather forecast for tomorrow?"
}
```

* **Response:**

```json
{
  "contextualPrompt": "🕒 Date and time: ...\n📍 Location: Porto Alegre...\n🌤️ Weather: 26°C, clear skies\n..."
}
```

---

### 🔹 Endpoint: Generate full AI response (OpenAI)

* **POST** `/api/prompt/complete`
* **Body:**

```json
{
  "userMessage": "Give me a productivity tip for today."
}
```

* **Response:**

```json
{
  "contextualPrompt": "...",
  "llmResponse": "Sure! You could try using the Pomodoro technique..."
}
```

---

## 📂 Project Structure

```
PresenceLayer/
├── Controllers/
├── Services/
├── Models/
├── Integrations/
├── Middleware/
├── Program.cs
├── appsettings.json
```

---

## 📌 Roadmap (WIP)

* [ ] Real location detection by IP
* [ ] Real weather from external APIs
* [ ] Persistent conversation memory
* [ ] Local model integration (Ollama, etc.)

---

## ✨ Author

Jefferson Dewes
🔗 [github.com/jeffdwsa](https://github.com/jeffdwsa)

---

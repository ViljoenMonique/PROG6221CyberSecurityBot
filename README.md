#  Cybersecurity Awareness Bot

**PROG6221 Part 1 - Basic Chatbot Interaction with Voice Greeting & Image**

A friendly C# console chatbot designed to educate users about cybersecurity.

##  Features

-  **Voice Greeting** on startup (using recorded `greeting.wav`)
-  **Custom ASCII Art** header ("Your Cyber Friend")
-  **Personalised greeting** – asks for your name
-  **Professional typing effect** on all responses
-  **Interactive chatbot** with expanded cybersecurity responses
-  Enhanced console UI with colours, borders and clean formatting
-  Proper input validation

##  How to Run

1. Clone or download the repository
2. Open `CyberSecurityBot.slnx` in Visual Studio 2022
3. Ensure `greeting.wav` is inside the `Assets` folder and set to **Copy always**
4. Press `F5`

##  Project Structure

```bash
CyberSecurityBot/
├── Assets/
│   └── greeting.wav
├── AudioPlayer.cs
├── Chatbot.cs
├── Program.cs
├── User.cs
├── README.md
└── .github/workflows/dotnet.yml

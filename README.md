this is my video demo here
https://youtu.be/ij5uKhJqHmg

CyberSecurityBot 

A modular C# console application designed for cybersecurity awareness and interactive learning.

Features

    Object-Oriented Architecture: Logic is organized into separate User, Chatbot, and ResponseHandler classes for better maintainability.

    Multimedia Integration: Includes automated audio greetings using the Windows SoundPlayer API.

    Keyword Detection: The system identifies security topics like MFA, Phishing, and Passwords within natural language sentences.

    CI/CD Integration: Automated build testing is configured via GitHub Actions.

Tech Stack

    Language: C# (.NET 8.0)

    Development Environment: Visual Studio 2022

    Version Control: Git and GitHub

Project Structure

    Program.cs: Handles the main execution loop and user input.

    Chatbot.cs: Manages the visual interface, headers, and audio playback.

    ResponseHandler.cs: Contains the security knowledge base and response logic.

    User.cs: Stores session-specific user data.

Installation and Usage

    Open the solution file in Visual Studio 2022.

    In the Solution Explorer, ensure the welcome.wav file property "Copy to Output Directory" is set to "Copy if newer."

    Press F5 to build and run the application.

    Interact with the bot by asking security-related questions.

    Type "exit" to close the terminal securely.

Developed by shravan raguanan

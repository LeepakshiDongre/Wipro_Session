using System;

class ChatBot
{
    // Method to respond to a greeting
    public string Respond(string greeting)
    {
        if (greeting.ToLower() == "hello")
        {
            return "Hello! How can I help you today?";
        }
        else if (greeting.ToLower() == "hi")
        {
            return "Hi there! What can I do for you?";
        }
        else
        {
            return "Greetings! How may I assist you?";
        }
    }

    // Method to respond to a question, with casual or formal response based on a boolean value
    public string Respond(string question, bool isCasual)
    {
        if (isCasual)
        {
            return "Sure! That's a good question. Let's chat more about it!";
        }
        else
        {
            return "Certainly. I will provide you with a detailed response shortly.";
        }
    }

    // Method to respond to a numerical query (e.g., a math question)
    public string Respond(int number)
    {
        if (number < 10)
        {
            return "That's a small number! Do you want to know more about it?";
        }
        else if (number >= 10 && number <= 100)
        {
            return "That's a moderate number. Are you curious about something else?";
        }
        else
        {
            return "Wow, that's a big number! What else can I assist you with?";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a ChatBot object
        ChatBot bot = new ChatBot();

        // Call Respond() method with a greeting
        string greetingResponse = bot.Respond("hello");
        Console.WriteLine(greetingResponse);  // Output: Hello! How can I help you today?

        // Call Respond() method with a question and casual flag
        string questionResponseCasual = bot.Respond("What's the weather like?", true);
        Console.WriteLine(questionResponseCasual);  // Output: Sure! That's a good question. Let's chat more about it!

        // Call Respond() method with a question and formal flag
        string questionResponseFormal = bot.Respond("What's the weather like?", false);
        Console.WriteLine(questionResponseFormal);  // Output: Certainly. I will provide you with a detailed response shortly.

        // Call Respond() method with a numerical query
        string numberResponse = bot.Respond(15);
        Console.WriteLine(numberResponse);  // Output: That's a moderate number. Are you curious about something else?
    }
}

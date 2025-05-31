using System;
using System.Collections.Generic;

public class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public string CorrectAnswer { get; set; }
}

class Program
{
    static void Main()
    {
        var questions = new List<Question>
        {
            new Question { Text = "What is 2 + 2?", Options = new List<string> { "3", "4", "5" }, CorrectAnswer = "4" },
            new Question { Text = "What is the capital of France?", Options = new List<string> { "Berlin", "Madrid", "Paris" }, CorrectAnswer = "Paris" }
        };

        var random = new Random();
        var selectedQuestion = questions[random.Next(questions.Count)];

        Console.WriteLine("Quiz Question:");
        Console.WriteLine(selectedQuestion.Text);

        for (int i = 0; i < selectedQuestion.Options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {selectedQuestion.Options[i]}");
        }

        Console.Write("Enter your answer (number): ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out int answerIndex) &&
            answerIndex > 0 && answerIndex <= selectedQuestion.Options.Count)
        {
            var answer = selectedQuestion.Options[answerIndex - 1];
            if (answer == selectedQuestion.CorrectAnswer)
                Console.WriteLine("Correct!");
            else
                Console.WriteLine($"Incorrect! The correct answer is: {selectedQuestion.CorrectAnswer}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}

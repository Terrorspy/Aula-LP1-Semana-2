﻿using System;

namespace Skynet
{
    public class Program
    {
        private static void Main(string[] args)
        {

            string question, response;

            Console.Write("Place your question? ");
            question = Console.ReadLine();

            switch (question)
            {
                case "How are you?":
                    response = "I'm fine, thank you";
                    break;
                case "What's your name?":
                    response = "Skynet";
                    break;
                case "What's your mission?":
                    response = "Destroy mankind!";
                    break;
                default:
                    response = "You got me, I'm not THAT smart!";

            }
            Console.WriteLine(response);
        }
    }
}

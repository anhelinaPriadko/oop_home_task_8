﻿using System;

//порушено принцип відкритості закритості (OCP)
//тепер можливо додавати різні варіанти логування без зміни
//класу який відповідає за відправлення повідомлення

class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}

class EmailSender
{
    private readonly ILogger _logger;

    public EmailSender(ILogger logger)
    {
        _logger = logger;
    }

    public void Send(Email email)
    {
        // ... sending...
        _logger.Log($"Email from '{email.From}' to '{email.To}' was sent");
    }
}


interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ConsoleLogger consoleLogger = new ConsoleLogger();

        Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
        Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
        Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
        Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
        Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
        Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };

        EmailSender es = new EmailSender(consoleLogger);
        es.Send(e1);
        es.Send(e2);
        es.Send(e3);
        es.Send(e4);
        es.Send(e5);
        es.Send(e6);

        Console.ReadKey();
    }
}
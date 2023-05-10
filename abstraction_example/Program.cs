// See https://aka.ms/new-console-template for more information

Book mistborn = new Book("Mistborn", "Brandon Sanderson");
Book musashi = new Book("Musashi", "Eiji Yoshikawa");

mistborn.Display();
musashi.Display();

Console.WriteLine(mistborn.IsAvailable());

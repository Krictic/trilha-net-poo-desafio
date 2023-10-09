using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Criando celular nokia...");
var nokia = new Nokia("92389183", "G60", "832179273987126387916", memoria: 512);
nokia.Ligar("92213289183");
nokia.ReceberLigacao("92213289183");

nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Criando celular Iphone...");
var iPhone = new Iphone("92213289183", "IPhone 12X", "3831892839", memoria: 1024);
iPhone.Ligar("92389183");
iPhone.ReceberLigacao("92389183");
iPhone.InstalarAplicativo("Telegram");

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ExemploExplorando.Models;
using System.Globalization;
DateTime data = DateTime.Now;
DateTime data2 = DateTime.Parse("31/07/1982 18:15");

//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToLongDateString());
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
Console.WriteLine(data2);




//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
//decimal valorMonetario = 2582.40M;
//Console.WriteLine($"{valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
//Console.WriteLine($"{valorMonetario.ToString("N2")}");
//double porcentagem = .3421;
//Console.WriteLine(porcentagem.ToString("P"));
//int numero = 123456;
//Console.WriteLine(numero.ToString("##-##-##"));

//int numero1 = 10;
//int numero2 = 20;
//int resultado = numero1 + numero2;
//Console.WriteLine(resultado);

//Pessoa p1 = new Pessoa();
//p1.Nome = "Souza";
//p1.Sobrenome ="Silva";
//p1.Idade = 40;
//p1.Apresentar();
//Pessoa p1 = new Pessoa(nome:"Sonia", sobrenome: "Amancio");
//Pessoa p2 = new Pessoa("Arthur", "Souza");
//Pessoa p3 = new Pessoa("Alexandre", "Souza");

//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Ingles";
//cursoDeIngles.Alunos = new List<Pessoa>();

//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.AdicionarAluno(p3);
//cursoDeIngles.ListarAluno();




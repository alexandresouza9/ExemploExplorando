// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ExemploExplorando.Models;

//Pessoa p1 = new Pessoa();
//p1.Nome = "Souza";
//p1.Sobrenome ="Silva";
//p1.Idade = 40;
//p1.Apresentar();
Pessoa p1 = new Pessoa(nome:"Sonia", sobrenome: "Amancio");
Pessoa p2 = new Pessoa("Arthur", "Souza");
Pessoa p3 = new Pessoa("Alexandre", "Souza");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAluno();




// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Souza";
p1.Sobrenome ="Silva";
p1.Idade = 40;
p1.Apresentar();

Pessoa p2 = new Pessoa();
p2.Nome = "Arthur";
p2.Sobrenome = "Souza";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAluno();




// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ExemploExplorando.Models;
using System.Globalization;
//using Models;
using Newtonsoft.Json;

List<Venda> ListaVendas = new List<Venda>();

Venda v1 = new Venda(1, "material de escritório", 25.00M);
Venda v2 = new Venda(2, "Licença de Software", 110.00M);

ListaVendas.Add(v1);
ListaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(ListaVendas, Formatting.Indented);


File.WriteAllText("Arquivos/vendas.json", serializado);
Console.WriteLine(serializado);







// int numero = 100;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar? "par" : "impar"));

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }







// Pessoa p1 = new Pessoa("Alexandre", "Souza");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");
// LeituraArquivo arquivo = new LeituraArquivo();

// var(sucesso, linhasArquivo, quantidadesLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine("Quantidade linhas do arquivo:" + quantidadesLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler arquivo");
// }
// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Alexandre", "Souza", 10.80M);
// //ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Alexandre", "Souza", 10.80M);

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");

//Queue<int> fila = new Queue<int>();
//fila.Enqueue(2);
//fila.Enqueue(4);
//fila.Enqueue(6);
//fila.Enqueue(8);
//foreach (int item in fila)
//{
    //Console.WriteLine(item);
//}
//Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

//foreach (int item in fila)
//{
    //Console.WriteLine(item);
//}

//string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//try
//{
//foreach (string linnha in linhas)
//{
//    Console.WriteLine(linnha);
//}
//} catch(Exception ex)
//{
//    Console.WriteLine($"Ocorreu uma exceção genérica.{ex.Message}");
//}
//Console.WriteLine("Chegou até aqui!!!");

//DateTime data = DateTime.Now;
//DateTime data2 = DateTime.Parse("31/07/1982 18:15");

//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
//Console.WriteLine(data.ToLongDateString());
//Console.WriteLine(data.ToShortDateString());
//Console.WriteLine(data.ToShortTimeString());
//Console.WriteLine(data2);


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




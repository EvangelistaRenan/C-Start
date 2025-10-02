// See https://aka.ms/new-console-template for more information
#region Meu primeiro programa

//Console.WriteLine("Hello, World!");

#endregion
#region Tipos de Variaveis

// Sintaxe de Declaração de Variaveis
// Do tipo inteiro
// Que rege número não fracionários
// Exemplo 5, 10, 20, 30, -10, -20
int idade;
int idade02 = 34;

//Numero quebrado (numero com parte fracionaria)
double peso; //Exemplo 10.5, 25.0
double altura = 1.85;
double altura02 = 1;

// Texto (conkunto de caracteres)
string nome = "Renan"; // Exemplo: "José" "João" "Maria"
Console.WriteLine($"Seu nome é {nome}"); // Imprimir mensagem
Console.WriteLine("Seu nome é {0}", nome);

// Booleano (verdadeiro ou falso)
bool estudante;
bool estudante02 = true;
bool estudante03 = false;
bool valor = 2 < 3;

#endregion
#region Entrada e Saida de Dados
// Inserir dados dentro de uma variavel
Console.WriteLine("Digite uma cor: "); // Imprimir mensagem
string nomeInput = Console.ReadLine()!; // Ler dados do Usuário
Console.WriteLine($"Sua cor é {nomeInput}"); // Imprimir Dados do usuário
#endregion

#region Tipos de Variáveis

/*var nome = Console.ReadLine();

Console.WriteLine(nome);

double valorDouble = 3.14;
float valorFloat = 3.14f;
decimal valorDecimal = 3.14M;
int valorInteiro = 100;
bool valorBoolean = true;
char valorChar = 'a';
string valorString = "Thais";

const double PI = 3.1416; ///Não permite alterar o valor

Console.WriteLine($"Double: {valorDouble}, float: {valorFloat}, Decimal {valorDecimal}, Int: {valorInteiro}, Boolean: {valorBoolean}, Char: {valorChar}, String: {valorString}");
*/
#endregion

#region Operadores Aritméticos
/*int a = 1;
int b = 2;

int soma = a + b; // 3
int subtracao = a - b; // -1
int multiplicacao = a * b; // 2
int divisao = b / a; // 2
int modulo = a % b; // 1

Console.WriteLine($"Soma: {soma}, Subtração: {subtracao}, Multiplicação: {multiplicacao}, Divisão: {divisao}, Modulo: {modulo}");
*/
#endregion

#region Operadores de Comparação
/*var p = 5;
var q = 10;

bool maior = p > q; // False
bool maiorOuIgual = p >= q; // False
bool menor = p < q; // True
bool menorOuIgual = p <= q; // True
bool igual = p == q;  // False
bool diferente = p != q; // True

Console.WriteLine($"Maior: {maior}, Maior ou Igual: {maiorOuIgual}, Menor: {menor}, Menor Ou Igual: {menorOuIgual} " +
                  $"Igual: {igual}, Diferente: {diferente}");
*/
#endregion

#region Operadores Lógicos
/*
bool x = true;
bool y = false;

var and = x && y; // AND: FALSE - os dois precisam ser verdadeiros.
var or = x || y; // OR: TRUE - um ou outro precisa ser verdadeiro, só precisa de um.
var notX = !x; // NOT: FALSE - vai inverter, se estiver false muda pra true e vice versa.
var notY = !y; // NOT: TRUE - vai inverter, se estiver false muda pra true e vice versa.

Console.WriteLine($"AND: {and}, OR:C{or}, NOT X: {notX}, NOT Y: {notY});
*/
#endregion

#region Operadores de Igualdade e Atribuição
/*int k = 5;
k = 10;

k += 5; // k = k + 5 = 10 + 5 = 15
k -= 3; // k = k - 3 = 15 - 3 = 12
k *= 2; // k = k * 2 = 12 * 2 = 24
k /= 4; // k = k / 4 = 24 / 4 = 6
k %= 5; // k = k % 5 = 6 % 5 = 1
*/
#endregion

#region Estruturas Condicionais - if else
/*
//Exemplo 1:
var nota = 75;

if (nota >= 70)
{
    Console.WriteLine("Aprovado!");
}
else if (nota >= 30)
{
    Console.WriteLine("Em recuperação");
}

else
{
    Console.WriteLine("Reprovado");
}

Console.WriteLine("------------------------------------------");
//Exemplo 2:

int idade = 18;

if (idade < 18)
{
    Console.WriteLine("Você é menor de idade.");
}
else if (idade >= 18 && idade < 60)
{
    Console.WriteLine("Você é um adulto.");
}
else
{
    Console.WriteLine("Você é um idoso.");
}
*/
#endregion

#region Estruturas Condicionais - switch case
/*
int diaDaSemana = 3;
string nomeDoDia;
switch (diaDaSemana)
{
    case 1:
        nomeDoDia = "Segunda-feira";
        break;
    case 2:
        nomeDoDia = "Terça-feira";
        break;
    case 3:
        nomeDoDia = "Quarta-feira";
        break;
    case 4:
        nomeDoDia = "Quinta-feira";
        break;
    case 5:
        nomeDoDia = "Sexta-feira";
        break;
    case 6:
        nomeDoDia = "Sábado";
        break;
    case 7:
        nomeDoDia = "Domingo";
        break;
    default:
        nomeDoDia = "Dia inválido";
        break;
}
Console.WriteLine($"Hoje é {nomeDoDia}.");

Console.WriteLine("-----------------------------------------");

var nota = 25;

switch (nota)
{
    case int n when n >= 70:
        Console.WriteLine("Aprovado");
        break;

    case int n when n <= 30:
        Console.WriteLine("Reprovado");
        break;
}
*/
#endregion

#region Matrizes
/*int[] matriz = { 1, 4, 3, 2, 6 };
int[] matrizVazia = new int[5];

var tamanhoMatriz = matriz.Length;
var dimensaoMatriz = matriz.Rank;

Console.WriteLine($"Tamanho {tamanhoMatriz}, Dimensão {dimensaoMatriz}");

Array.Sort(matriz);
Array.Reverse(matriz);
*/
#endregion

#region Estruturas de Repetição
/*int[] matriz = { 1, 4, 3, 2, 6 };

Console.WriteLine("While"); // Enquanto a condição for verdadeira.

int contador = 0;

while (contador < matriz.Length)
{
    Console.WriteLine(matriz[contador]); // matriz[0], matriz [1].....
    //contador = contador + 1;
    contador++;
}

Console.WriteLine("do-While");

contador = 0;
do
{
    Console.WriteLine(matriz[contador]);//executa pelo menos uma vez
    contador++;
} while (contador < matriz.Length);

Console.WriteLine("for");
for (int i = 0; i <matriz.Length; i++)// começa em 0, executa 1 vez e encrementa.
{
    Console.WriteLine(matriz[i]);
}

Console.WriteLine("foreach");
foreach (int numero in matriz)
{
    Console.WriteLine(numero);
}
*/
#endregion

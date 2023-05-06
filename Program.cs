using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.InteropServices.ObjectiveC;

Console.WriteLine("Hello, World! Fala Sub!");

Console.WriteLine("------------------------");
Console.WriteLine("Declarando Variaveis Numéricas");

byte valor1 = 255;
sbyte valor2 = -127;
int valor3 = 303;
uint valor4 = 2302;
long valor5 = 3023920320;
int var1 = 5, var2 = 3, var3 = 4;
double valor6 = 14.4;
float valor7 = 12.3f;
decimal valor8 = 323.42M;

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(var1);
Console.WriteLine(var2);
Console.WriteLine(var3);
Console.WriteLine(valor6);
Console.WriteLine(valor7);
Console.WriteLine(valor8);
Console.WriteLine("------------------------");

Console.WriteLine("Comparando a precisão de float, double e decimal");
float x = 1f / 3f;
double y = 1d / 3d;
decimal w = 1m / 3m;
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(w);
Console.WriteLine("------------------------");

Console.WriteLine("Tipos não numéricos Bool e Char");
bool ativo = true;
char letra1 = 'a';
Console.WriteLine(valor2 > valor3);
Console.WriteLine(ativo);
Console.WriteLine(letra1);

Console.WriteLine("------------------------");
Console.WriteLine("Tipos de referencia");
string nome = "Ronaldo Machado dos Santos";
object nota = 10;
object valor = 120.3m;
object nome2 = "Maria";
dynamic nome3 = "Carol";
Console.WriteLine(nome);
Console.WriteLine(nota);
Console.WriteLine(valor);
Console.WriteLine(nome2);
Console.WriteLine(nome3);
Console.WriteLine("------------------------");

Console.WriteLine("Tratando Data/Hora com DateTime");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
DateTime dataHoje = new DateTime(2022, 09, 07);
Console.WriteLine(dataHoje);

Console.WriteLine("------------------------");

Console.WriteLine("Nullable Types");

Nullable<int> inull = null;
Nullable<double> dnull = null;
Nullable<bool> bnull = null;

int? inull2 = null;
double? dnull2 = null;
bool? bnull2 = null;

int? xxx = null;
int xxy = xxx ?? 0;


Console.ReadLine();
int? bbb = 100;
if (bbb.HasValue)
{
    Console.WriteLine($"b ={bbb.Value}");
}
else
{
    Console.WriteLine("b não possui um valor (null)");
}
Console.WriteLine("------------------------");

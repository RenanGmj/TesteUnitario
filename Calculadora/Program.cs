using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();
int a = 8;
int b = 1;

Console.WriteLine($"A soma de {a} + {b} = {c.Somar(a, b)}");
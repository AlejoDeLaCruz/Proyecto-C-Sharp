// See https://aka.ms/new-console-template for more information

string mensaje = "Hola Mundo!!";

Console.WriteLine(mensaje);

int num1;
int num2;

Console.WriteLine("Ingrese el primer numero a sumar.");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el primer numero a sumar.");
num2 = Convert.ToInt32(Console.ReadLine());

int total = num1 + num2;

Console.WriteLine("El resultado de la suma es: " + total);

Console.ReadKey();

using Dolar;
using System.Globalization;

ConversorDeMoeda converte = new ConversorDeMoeda();

Console.Write("Qual é a cotação do dolar ?");
converte.Dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Quantos dolares você vai comprar ?");
converte.QuantiDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.Write("Valor a ser pago em reais:" + converte.Real().ToString("F2",CultureInfo.InvariantCulture));

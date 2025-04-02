double number1;
double number2;
double number3;
double media;

Console.Clear();

Console.WriteLine("--- Média Aritmética de 3 números ---");

Console.Write(@"
Digite o primeiro número: ");
number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número.: ");
number2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
number3 = Convert.ToDouble(Console.ReadLine());

media = (number1 + number2 + number3) / 3;

Console.WriteLine(@$"
Média: {media}");
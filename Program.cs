////////////////////////////////////////
//Entrada
Console.WriteLine("Calculadora");
repeat1:
Console.WriteLine("Qual operação você deseja realizar? \n[1] Soma \n[2] Subtração \n[3] Multiplicação \n[4] Divisão");
string op = Console.ReadLine();
Console.Write("Digite o primeiro número: ");
double n1 = double.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
double n2 = double.Parse(Console.ReadLine());

//////////////////////////////////////
///Processamento
double Somar(double n1, double n2)
{
    double sum = n1 + n2;
    return sum;
}

double Subtrair(double n1, double n2)
{
    double sub = n1 - n2;
    return sub;
}

double Dividir(double n1, double n2)
{
    double div = n1 / n2;
    return div;
}

double Multiplicar(double n1, double n2)
{
    double mult = n1 * n2;
    return mult;
}
/////////////////////////////////////////
//Saídas
switch (op)
{
    case "1":
        Console.WriteLine($"Você escolheu a operação de soma. \nO resultado da operação é igual a {Somar(n1, n2)}");
        break;

    case "2":
        Console.WriteLine($"Você escolheu a operação de subtração. \nO resultado da operação é igual a {Subtrair(n1, n2)}");
        break;

    case "3":
        Console.WriteLine($"Você escolheu a operação de multiplicação. \nO resultado da operação é igual a {Multiplicar(n1, n2)}");
        break;

    case "4":
        Console.WriteLine($"Você escolheu a operação de divisão. \nO resultado da operação é igual a {Dividir(n1, n2)}");
        break;
    default:
        Console.WriteLine($"Operação inálida. Tente novamente ;c");
        goto repeat1;
}





Console.WriteLine("Pressione qualquer tecla para encerrar..");
Console.ReadKey();
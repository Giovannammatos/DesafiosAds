namespace CalculadoraCsharp;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Insira o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o simbolo da operação (+, -, *, /): ");
        string operador = Console.ReadLine();

        if (operador == "+")
        {
            Console.WriteLine(num1 + num2);
        }
        else if (operador == "-")   
        {
            Console.WriteLine(num1 - num2);
        }
        else if (operador == "*")   
        {
            Console.WriteLine(num1 * num2);
        }
        else if (operador == "/")   
        {
            if (num2 == 0)
                Console.WriteLine("Não divisivel por 0");
            else      
                Console.WriteLine(num1 / num2);
        }
        else
            Console.WriteLine("Digite um operador válido");
    }
}

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();    //limpar tela
            Console.WriteLine("Selecione a operação\n 1- Adição\n 2- Subtração\n 3- Multiplicação\n 4- Divisão\n 0- Sair");
            short op = short.Parse(Console.ReadLine());


            switch (op)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                default:
                    Menu();
                    break;
            }

        }
        static void Soma()
        {
            Console.Clear();    //limpar tela
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine("");
            Console.WriteLine("Digite enter para voltar ao menu!");
            Console.ReadKey();
            Menu();

        }

        static void Subtracao()
        {
            Console.Clear();    //limpar tela
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 - v2;
            Console.WriteLine("O resultado da subtração é: " + resultado);
            Console.WriteLine("");
            Console.WriteLine("Digite enter para voltar ao menu!");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();    //limpar tela
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            Console.WriteLine("O resultado da multiplicação é: " + resultado);
            Console.WriteLine("");
            Console.WriteLine("Digite enter para voltar ao menu!");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();    //limpar tela
            Console.WriteLine("Primeiro valor (numerador): ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor(denominador): ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 / v2;
            Console.WriteLine("O resultado da divisão é: " + resultado);
            Console.WriteLine("");
            Console.WriteLine("Digite enter para voltar ao menu!");
            Console.ReadKey();
            Menu();
        }

    }
}
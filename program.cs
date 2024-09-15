using System;

namespace calculadoracientifica
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("escolha um numero:");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("escolha outro numero:");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("escolha opcao:");
            Console.WriteLine("1 - soma:");
            Console.WriteLine("2 - subtracao");
            Console.WriteLine("3 - divisao");
            Console.WriteLine("4 - multiplicacao");
            Console.WriteLine("5 - modo cientifico");
            short opcao = short.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1: Soma(n1, n2); break;
                case 2: Subtracao(n1, n2); break;
                case 3: Divisao(n1, n2); break;
                case 4: Multiplicacao(n1, n2); break;
                case 5: Cientifico(); break;
                default:
                Console.WriteLine("invalido");
                Menu(); break;
            }
        }
        static void Soma (float n1,float n2)
        {
            Console.Clear();
            Console.WriteLine($"sua soma totaliza: {n1 + n2}");
            Console.ReadLine();
            Menu();
        }
        static void Subtracao(float n1, float n2)
        {
            Console.Clear();
            Console.WriteLine($"sua subtracao otario, totaliza {n1 - n2}");
            Console.ReadLine();
            Menu();
        }
        static void Divisao(float n1, float n2)
        {
            Console.Clear();
            Console.WriteLine($"sua subtracao otario, totaliza {n1 / n2}");
            Console.ReadLine();
            Menu();
        }
        static void Multiplicacao(float n1, float n2)
        {
            Console.Clear();
            Console.WriteLine($"sua multiplicacao fdp, totaliza {n1 * n2}");
            Console.ReadLine();
            Menu();
        }
        static void Cientifico()
        {
            Console.Clear();
        }
        

    }
    
}



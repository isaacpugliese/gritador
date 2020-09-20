using System;

namespace gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma Frase: ");
            string Frase = Console.ReadLine();
            Console.Clear();
            Console.Write(Frase.ToUpper()+"!");           
        }
    }
}

using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura; 
            bool feminino; 
            double resultfeminino, resultmasculino;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(" ----- PESO IDEAL <3 ----- \n");
                            
            Console.ForegroundColor = ConsoleColor.White;
            
                    Console.Write("Digite sua altura em m..........:");
                             altura = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Sexo [M]asculino / [F]eminino...:");
                                            feminino = Console.ReadLine().ToUpper() == "F";  

            resultfeminino = altura * 62.1 - 44.7;
            resultmasculino = altura * 72.7 - 58;

            if (feminino)
                Console.WriteLine($"Seu peso ideal é {resultfeminino} kg.");

            else 
                Console.WriteLine($"Seu peso ideal é {resultmasculino} kg.");     

            Console.ReadKey();                             

        }
    }
}

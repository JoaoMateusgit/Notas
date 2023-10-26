
using Notas;
using System.Globalization;
namespace course
{
    class Program
    {
        static void Main(String[] args)
        {

            boletim a = new boletim();

            Console.WriteLine("digite a primeira nota: ");
            a.NotaUM = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a segunda nota: ");
            a.NotaDois = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a terceira nota: ");
            a.NotaTres = double.Parse(Console.ReadLine());



            if (a.Somar() <= 60)
            {
                Console.WriteLine("Reprovado, faltou: " + a.Falta() + " Pontos");
            }
            else
            {
                Console.WriteLine("Aprovado.");
            }
        }
    }
}

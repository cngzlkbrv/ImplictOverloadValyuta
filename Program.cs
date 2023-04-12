using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar = new Dollar(17);
            Manat manat = dollar;
            Console.WriteLine(manat.Money);
            Euro euro=new Euro(17);
            Manat manat1= euro;
            Console.WriteLine(manat1.Money);
        }
    }
}
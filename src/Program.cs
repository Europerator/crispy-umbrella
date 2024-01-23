// See https://aka.ms/new-console-template for more information

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne unePersonne;
            unePersonne =  new  Personne("Alibert", "Louis"); 
            Console.WriteLine(unePersonne.Infos());      
        }
    } 
}
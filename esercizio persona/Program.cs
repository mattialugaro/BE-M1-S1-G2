using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona pers1 = new Persona();
            pers1.Nome = "Franco";
            pers1.Cognome = "Juan";
            pers1.Eta = 33;
            Console.WriteLine(pers1.getNome());
            Console.WriteLine(pers1.getCognome());
            Console.WriteLine(pers1.getEta());
            string messaggio = pers1.getDettagli();
            Console.WriteLine(messaggio);
            Console.WriteLine("pers1 si chiama: " + pers1.Nome + " " + pers1.Cognome + " e ha " + pers1.Eta + " anni. \n");

            Persona pers2 = new Persona();
            pers2.Nome = "GianGiacomo";
            pers2.Cognome = "Giangi";
            pers2.Eta = 65;
            Console.WriteLine(pers2.getNome());
            Console.WriteLine(pers2.getCognome());
            Console.WriteLine(pers2.getEta());
            Console.WriteLine(pers2.getDettagli());
            Console.ReadLine();

            Console.WriteLine("Scrivi il tuo nome...");
            var nome = Console.ReadLine();
            Console.WriteLine("Scrivi il tuo cognome...");
            var cognome = Console.ReadLine();
            Console.WriteLine("Scrivi la tua eta'...");
            var eta = Console.ReadLine();
            Console.WriteLine("Ti chiami " + nome + " " + cognome + " e hai " + eta + " anni.");
            Console.ReadLine();

        }
    }
}

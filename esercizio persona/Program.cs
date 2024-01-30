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
            // pers1.Indirizzo = "via Roma 23";
            Console.WriteLine(pers1.getNome());
            Console.WriteLine(pers1.getCognome());
            Console.WriteLine(pers1.getEta());
            // Console.WriteLine("pers1 abita in " + pers1.Indirizzo);
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
            Console.WriteLine("pers2 si chiama: " + pers2.Nome + " " + pers2.Cognome + " e ha " + pers2.Eta + " anni. \n");
            // Console.ReadLine();

            Console.WriteLine("Scrivi il tuo nome...");
            string nome = Console.ReadLine();
            Console.WriteLine("Scrivi il tuo cognome...");
            string cognome = Console.ReadLine();
            Console.WriteLine("Scrivi la tua eta'...");
            int eta = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ti chiami " + nome + " " + cognome + " e hai " + eta + " anni.");
            Console.ReadLine();

        }
    }
}

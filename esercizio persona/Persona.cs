using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_persona
{
    public class Persona
    {
        private string _nome;
        private string _cognome;
        private int _eta;
        // private string _indirizzo;

        // public string Indirizzo { get; set; }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }

        public int Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                _eta = value;
            }
        }

        public Persona() { }

        public Persona(string nome, string cognome, int eta)// , string indirizzo)
        {
            _nome = nome;
            _cognome = cognome;
            _eta = eta;
            // _indirizzo = indirizzo;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getCognome()
        {
            return Cognome;
        }

        public int getEta()
        {
            return Eta;
        }

        public string getDettagli()
        {
            return Nome + " " + Cognome + " " + Eta + " anni";
        }

    }

}
